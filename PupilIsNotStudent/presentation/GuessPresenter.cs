using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.model.interactor;
using PupilIsNotStudent.utils;

namespace PupilIsNotStudent.presentation
{
    class GuessPresenter
    {
        private readonly GuessView view;
        private readonly GuessInteractor interactor;
        
        //TODO RED 
 //       TextJsonRepository newsJson;

        public GuessPresenter(GuessView view, GuessInteractor interactor)
        {
            this.view = view;
            this.interactor = interactor;
            load();
        }
        //DESTRUCT


        public void onBtnGuessCategoryClicked(string textToBeAnalyzed)
        {

            string[] wordsCategoryToGuess = interactor.splitToWords(textToBeAnalyzed);
            view.clearPreviousResults();

            // Do not repeat words
            
            onBtnComputeDisperseEstimationClicked(textToBeAnalyzed);


            Dictionary<string, int> n = interactor.associateOccurrencesWithTerms(ref wordsCategoryToGuess);
            IndicatorsOfAffiliationForText scores;


            foreach (KeyValuePair<string, Book> category in interactor.getLibrary())  // category, a category properties
            {
                // here we have Category(category.Key) and array of unrepeated words(category.Value.allWords)
                // also, there is array of repeated words(wordsCategoryToGuess)
              
                view.initializeNewRow();
                view.showCategoryNameInCurRow(category.Key);
                interactor.openNewLogFile(category.Key);

                scores = interactor.computeAffiliationOfTextToCategory(n.Keys, category.Value.TFIDF);
                //                myGrid.Rows[ind].Cells[1].Value = countOfCommonElem;

                // myGrid.Rows[ind].Cells[1].Value = Math.Round(tfidfTotalScore, 4);//Math.Round(100.0 * countOfCommonElem / Math.Min(category.Value.TFIDF.Count, keyWordsLimit), 1);
                //(float)100 * countOfCommonElem / (n.Count);  // percent
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
            interactor.relearn("Політика", in wordsCategoryToGuess);
         //interactor.getSplitWords();

         // TODO вставляти вже відсортовані данні
         // DataGridViewColumn newColumn =
         /*
         myGrid.Columns.GetColumnCount(
         DataGridViewElementStates.Selected)
         == 1
         ? myGrid.SelectedColumns[0]
          : null;
         //*/

         //ListSortDirection direction = ListSortDirection.Ascending;
         /*if (newColumn!= null)
                 myGrid.Sort(myGr, direction);
         else
             MessageBox.Show("Select a single column and try again.",
             "Error: Invalid Selection", MessageBoxButtons.OK,
             MessageBoxIcon.Error);*/
        }

        public void onBtnComputeDisperseEstimationClicked(string textToBeAnalyzed)
        {
            // string peeledText = getRawText(richTBtoAnalyze.Text.ToString());//todo optimise speed
            string resultOfDispersionEstimation = interactor.computeDe(interactor.getRawTextSplit(textToBeAnalyzed));
           

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
            // error message prints in the newsJson.load().catch
        }



        private bool load()
        {
            bool success = interactor.deserializeFromFile();
            view.setCategories(interactor.getCategories().ToArray());
            return success;
        }


    }
}
