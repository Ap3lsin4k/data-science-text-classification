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
        private readonly CategoriesView _view;
        private readonly CategoriesInteractor _interactor;

        public CategoriesPresenter(CategoriesView view, CategoriesInteractor interactor)
        {
            this._view = view;
            this._interactor = interactor;
        }

        public void OnBtnTermFrequencyClicked(string catg, string textToBeAnalyzed)
        {
            // calculate TermFrequency to all categories and then press IDF. Then TermFrequencyIDF.

            if (string.IsNullOrWhiteSpace(catg))
            {
                _view.show("Please enter or chose the category");
                return;
            }

            //feature if the field is not empty then learn
            if (!string.IsNullOrWhiteSpace(textToBeAnalyzed))
            {
                /*
                 * create new category &save only unique words
                 * rewrite if category already exists
                */
                _interactor.addCategory(catg, _interactor.getSplitWords(textToBeAnalyzed));

                _interactor.computeTermFrequencyAltogether(catg);

                _view.setCategories(_interactor.getCategories().ToArray());
            }
            else
            {
                //feature if the textBox is empty then show saved data

                if (_interactor.whetherCategoryExist(catg))
                {
                    _view.show("Write some texts to update the network");
                }
                else
                {
                    _view.show("The category \"" + catg +
                               "\" was not created. To create this category enter text of news in the TextBox");
                }
            }
        }

        public void OnBtnInverseDocumentFrequencyClicked(string currentCategory)
        {
            if (_interactor.getNumberOfShelvesInLibrary() != 0)
            {
                // calculate IDF for each category
                _interactor.IDFForEachBook();
                _view.show("Success");
            }
            else
                _view.show("There is no category to calculate the Inverse Document Frequency");
        }

        public void OnBtnTermFrequencyInverseDocumentFrequencyClicked(string catg)
        {
            if (_interactor.getNumberOfShelvesInLibrary() != 0)
            {
                foreach (string shelf in _interactor.getCategories())
                {
                    if (_interactor.TermFrequencyExist(shelf) && _interactor.InverseDocumentFrequencyExist(shelf))
                    {
                        _interactor.calculateTermFrequencyInverseDocumentFrequency(shelf);
                    }
                    else
                    {
                        _view.show("Error. TermFrequency exist:" + _interactor.TermFrequencyExist(shelf) +
                                   ",\tInverseDocumentFrequency exist:" +
                                   _interactor.InverseDocumentFrequencyExist(shelf) + "; for category: \"" + catg +
                                   "\". " +
                                   "TermFrequency and InverseDocumentFrequency needs to be computed before proceeding.");
                    }
                }
            }
            else
                _view.show("There is no categories to calculate TermFrequency*InverseDocumentFrequency");
        }

        public void OnBtnSaveClicked()
        {
            _interactor.saveToJsonFile();
            _view.show("Successfully saved");
        }

        public void OnBtnLoadTextFromFileClicked()
        {
            /*
             * open explorer to choose a file. It freezes all the process until the OK button will be pressed.
             * "false" means that user pressed "Cancel"
             */
            if (_interactor.openFileDialog())
            {
                string text = _interactor.readTexTermFrequencyromFile();
                _view.loadEditableText(text);
            }
        }
    }
}