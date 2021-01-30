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
        private readonly IGuessView _view;
        private readonly GuessInteractor _interactor;

        public GuessPresenter(IGuessView view, GuessInteractor interactor)
        {
            this._view = view;
            this._interactor = interactor;
            Load();
        }
        //DESTRUCT


        public void OnBtnGuessCategoryClicked(string textToBeAnalyzed)
        {

            string[] wordsCategoryToGuess = _interactor.GetSplitWords(textToBeAnalyzed);
            _view.ClearPreviousResults();

            // Do not repeat words
            
            OnBtnComputeDisperseEstimationClicked(textToBeAnalyzed);


 //           string[] uniqueWords = interactor.associateOccurrencesWithTerms(ref wordsCategoryToGuess);

            var uniqueWords = new HashSet<string>(wordsCategoryToGuess);
            IndicatorsOfAffiliationForText scores;

            foreach (KeyValuePair<string, Book> category in _interactor.GetLibrary())  // category, a category properties
            {
                // here we have CategoryName(category.Key)
              
                _view.InitializeNewRow();
                _view.ShowCategoryNameInCurRow(category.Key);
                //interactor.openNewLogFile(category.Key);

                scores = _interactor.ComputeAffiliationOfTextToCategory(in uniqueWords, category.Value.TFIDF,
                    category.Key);
                //interactor.closeLogFile();
                
                _view.ShowTfidfInCurRow(Math.Round(scores.NormalizedTfidf, 4));
                

                _view.ShowDeInCurRow(Math.Round(scores.De, 4));
                _view.ShowTotalScoreInCurRow(Math.Round(scores.NormalizedTfidf * scores.De, 4));
                
                // end writing log
            }

            // sorting by importance coefficient
            _view.SortThroughResultsByTfidf();


            // Re-Learner Update Knowledge
            if(false) _interactor.Relearn("Наука", in wordsCategoryToGuess);
        }

        public void OnBtnComputeDisperseEstimationClicked(string textToBeAnalyzed)
        {
            string resultOfDispersionEstimation = _interactor.ComputeDe(_interactor.GetSplitWords(textToBeAnalyzed));
           

            _view.ShowLongDebugLogDe(resultOfDispersionEstimation);
        }

        public void OnBtnLoadTextFromFileClicked()
        {
            if (_interactor.OpenFileDialog())
            {
                _view.LoadEditableText(_interactor.ReadTextFromFile());
            }
        }



        public void OnBtnLoadJsonClicked()
        {
            if (Load())
                _view.Show("Successfully loaded from \"analysis.json\"");
        }



        private bool Load()
        {
            // error message is in the newsJson.load().catch
            bool success = _interactor.DeserializeFromFile();
            _view.SetCategories(_interactor.GetCategories().ToArray());
            return success;
        }


    }
}
