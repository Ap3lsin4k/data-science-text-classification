using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PupilIsNotStudent.automated_testing;
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.model.interactor;


namespace PupilIsNotStudent.presentation
{
    internal class CategoriesPresenter
    {
        // TextJsonRepository newsJson;
        private readonly ICategoriesView _view;
        private readonly CategoriesInteractor _interactor;

        public CategoriesPresenter(ICategoriesView view, CategoriesInteractor interactor)
        {
            this._view = view;
            this._interactor = interactor;
        }
        
        internal void OnFitTermFreqInverseDocFreqFromFolder()
        {
            _interactor.FitTermFreqInverseDocFreqFromFolder();
            TrainingDocView.ProcessBrowserDir(FitFromFiles);

        }


        private void FitFromFiles(string[] filePaths)
        {
            foreach (string path in filePaths)
            {
                AppendTrainingDoc(TrainingDocView.GetCategoryNameFromPath(path), 
                    File.ReadAllText(path));
            }

            OnSavingTrainDocsFinished();
        }


        public void OnBtnTermFrequencyClicked(string catg, string textToBeAnalyzed)
        {
            // calculate TermFrequency to all categories and then press IDF. Then TermFrequencyIDF.

            if (string.IsNullOrWhiteSpace(catg))
            {
                _view.Show("Please enter or chose the category");
                return;
            }

            //feature if the field is not empty then learn
            if (!string.IsNullOrWhiteSpace(textToBeAnalyzed))
            {
                AppendTrainingDoc(catg, textToBeAnalyzed);
                _view.Show("Success");

            }
            else
            {
                // todo feature if the textBox is empty then show saved data

                if (_interactor.WhetherCategoryExist(catg))
                {
                    _view.Show("Write some texts to update the network");
                }
                else
                {
                    _view.Show("The category \"" + catg +
                               "\" was not created. To create this category enter text of news in the TextBox");
                }
            }
        }

        private void AppendTrainingDoc(string catg, string textToBeAnalyzed)
        {
            /*
                 * create new category &save only unique words
                 * rewrite if category already exists
                */
            _interactor.AppendCategory(catg, _interactor.GetSplitWords(textToBeAnalyzed));

            _interactor.ComputeTermFrequencyAltogether(catg);

            _view.SetCategoriesNames(_interactor.GetCategories().ToArray());

            _interactor.SaveToJsonFile();

        }

        public void OnBtnInverseDocumentFrequencyClicked()
        {
            if (_interactor.GetNumberOfShelvesInLibrary() != 0)
            {
                // calculate IDF for each category
                _interactor.IDFForEachBook();
                _interactor.SaveToJsonFile();

                _view.Show("Success");
            }
            else
                _view.Show("There is no category to calculate the Inverse Document Frequency");
        }

        public void OnBtnTermFrequencyInverseDocumentFrequencyClicked()
        {
            if (_interactor.GetNumberOfShelvesInLibrary() != 0)
            {
                TFIDFForEachCategory();
                _view.Show("Finished computing Term Frequency * Inverse Document Frequency");
                _interactor.SaveToJsonFile();
            }
            else
                _view.Show("There is no categories to calculate TermFrequency*InverseDocumentFrequency");
        }

        
        
        


        public void OnSavingTrainDocsFinished()
        {
            if (_interactor.GetNumberOfShelvesInLibrary() == 0)
            {
                _view.Show("There is no categories to calculate TermFrequency*InverseDocumentFrequency");
            }

            _interactor.IDFForEachBook();
            TFIDFForEachCategory();
            _interactor.SaveToJsonFile();
        }

        private void TFIDFForEachCategory()
        {
            foreach (string shelf in _interactor.GetCategories())
            {
                if (_interactor.TermFrequencyExist(shelf) && _interactor.InverseDocumentFrequencyExist(shelf))
                {
                    _interactor.CalculateTermFrequencyInverseDocumentFrequency(shelf);
                }
                else
                {
                    _view.Show("Error. TermFrequency exist:" + _interactor.TermFrequencyExist(shelf) +
                               ",\tInverseDocumentFrequency exist:" +
                               _interactor.InverseDocumentFrequencyExist(shelf) + "; for category: \"" + shelf +
                               "\". " +
                               "TermFrequency and InverseDocumentFrequency needs to be computed before proceeding.");
                }
            }
        }
    }
}