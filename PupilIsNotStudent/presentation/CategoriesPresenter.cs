using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                /*
                 * create new category &save only unique words
                 * rewrite if category already exists
                */
                _interactor.AddCategory(catg, _interactor.GetSplitWords(textToBeAnalyzed));

                _interactor.ComputeTermFrequencyAltogether(catg);

                _view.SetCategories(_interactor.GetCategories().ToArray());

                _interactor.SaveToJsonFile();

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

        public void OnBtnInverseDocumentFrequencyClicked(string currentCategory)
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

        public void OnBtnTermFrequencyInverseDocumentFrequencyClicked(string catg)
        {
            if (_interactor.GetNumberOfShelvesInLibrary() != 0)
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
                                   _interactor.InverseDocumentFrequencyExist(shelf) + "; for category: \"" + catg +
                                   "\". " +
                                   "TermFrequency and InverseDocumentFrequency needs to be computed before proceeding.");
                    }
                }
                _view.Show("Finished computing Term Frequency * Inverse Document Frequency");
                _interactor.SaveToJsonFile();
            }
            else
                _view.Show("There is no categories to calculate TermFrequency*InverseDocumentFrequency");
        }

        public void OnBtnLoadTextFromFileClicked()
        {
            /*
             * open explorer to choose a file. It freezes all the process until the OK button will be pressed.
             * "false" means that user pressed "Cancel"
             */
            if (_interactor.OpenFileDialog())
            {
                string text = _interactor.ReadTexTermFrequencyromFile();
                _view.LoadEditableText(text);
            }
        }
    }
}