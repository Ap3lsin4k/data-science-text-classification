using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using PupilIsNotStudent.automated_testing;
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.model.interactor;
using PupilIsNotStudent.model.repository;
using PupilIsNotStudent.utils;

namespace PupilIsNotStudent.presentation
{
    class GuessPresenter
    {
        private readonly GuessView view;
        private readonly GuessInteractor interactor;

        public GuessPresenter(GuessView view, GuessInteractor interactor)
        {
            this.view = view;
            this.interactor = interactor;
            load();
        }
        //DESTRUCT


        public void onBtnGuessCategoryClicked(string textToBeAnalyzed)
        {

            string[] wordsCategoryToGuess = interactor.getSplitWords(textToBeAnalyzed);
            view.clearPreviousResults();

            // Do not repeat words
            
            onBtnComputeDisperseEstimationClicked(textToBeAnalyzed);


 //           string[] uniqueWords = interactor.associateOccurrencesWithTerms(ref wordsCategoryToGuess);

            var uniqueWords = new HashSet<string>(wordsCategoryToGuess);
            IndicatorsOfAffiliationForText scores;

            foreach (KeyValuePair<string, Book> category in interactor.getLibrary())  // category, a category properties
            {
                // here we have CategoryName(category.Key)
              
                view.initializeNewRow();
                view.showCategoryNameInCurRow(category.Key);
                interactor.openNewLogFile(category.Key);

                scores = interactor.computeAffiliationOfTextToCategory(in uniqueWords, category.Value.TFIDF);
              
                view.showTfidfInCurRow(Math.Round(scores.normalizedTfidf, 4));
                

                if (scores.doesDeExist)
                {
                    view.showDeInCurRow(Math.Round(scores.de, 4));
                    view.showTotalScoreInCurRow(Math.Round(scores.normalizedTfidf * scores.de, 4));
                }
                else
                {
                    string brokenWords="";

                    foreach(string word in scores.getTermsWithBrokenDe())
                    {
                        brokenWords += '"' + word + "\", ";
                    }
                    view.show("The key(s) " + brokenWords + " was not found in the Dictionary of DispersionEstimation");
                }
                // end writing log
                interactor.closeLogFile();
            }

            // sorting by importance coefficient
            view.sortThroughResultsByTfidf();


            // Re-Learner Update Knowledge
            if(false) interactor.relearn("Наука", in wordsCategoryToGuess);
        }

        public void onBtnComputeDisperseEstimationClicked(string textToBeAnalyzed)
        {
            string resultOfDispersionEstimation = interactor.computeDe(interactor.getSplitWords(textToBeAnalyzed));
           

            view.showLongDebugLogDe(resultOfDispersionEstimation);
        }

        public void onBtnLoadTextFromFileClicked()
        {
            if (interactor.openFileDialog())
            {
                view.loadEditableText(interactor.readTextFromFile());
            }
        }



        public void onBtnLoadJsonClicked()
        {
            if (load())
                view.show("Successfully loaded from \"analysis.json\"");
        }



        private bool load()
        {
            // error message is in the newsJson.load().catch
            bool success = interactor.deserializeFromFile();
            view.setCategories(interactor.getCategories().ToArray());
            return success;
        }


    }
}
