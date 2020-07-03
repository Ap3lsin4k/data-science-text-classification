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
       private readonly CategoriesView view;
       private readonly CategoriesInteractor interactor;


        public CategoriesPresenter(CategoriesView view, CategoriesInteractor interactor) {
            this.view = view;
            this.interactor = interactor;
        }

        public void onBtnTfClicked(string catg, string textToBeAnalyzed)
        {
            // calculate TF to all categories and then press IDF. Then TFIDF.
            
            if (string.IsNullOrWhiteSpace(catg))
            {
                view.show("Please enter or chose the category");
                return;
            }


            //feature if the field is not empty then learn
            if (!string.IsNullOrWhiteSpace(textToBeAnalyzed))
            {
                /*
                 * create new category &save only unique words
                 * rewrite if category already exists
                */
                interactor.addCategory(catg, interactor.getSplitWords(textToBeAnalyzed)); // TODO test: test time for List-casting
                
                interactor.computeTFAltogether(catg);
                

                view.setCategories(interactor.getCategories().ToArray());
            }
            else
            {
                //feature if the textBox is empty then show saved data

                if (interactor.whetherCategoryExist(catg))
                {
                    view.show("Write some text to update the network");
                }
                else
                {
                    view.show("The category \"" + catg + "\" was not created. To create this category enter text of news in the TextBox");
                }

            }
        }



        public void onBtnIdfClicked(string currentCategory)
        {

            if (interactor.getNumberOfShelvesInLibrary() != 0)
            {
                // calculate IDF for each category
                interactor.IDFForEachBook();
                view.show("Success");
            }
            else
                view.show("There is no category to calculate the Inverse Document Frequency");
        }


        public void onBtnTfidfClicked(string catg)
        {

            if (interactor.getNumberOfShelvesInLibrary() != 0)
            {
                foreach (string shelf in interactor.getCategories())
                {
                    if (interactor.tfExist(shelf) && interactor.idfExist(shelf))
                    {
                        interactor.calculateTfIdf(shelf);
                    }
                    else
                    {
                        view.show("Error. TF exist:"
                                  + interactor.tfExist(shelf)
                                  +",\tIDF exist:"
                                  +interactor.idfExist(shelf)
                                  +"; for category: \"" + catg + "\". " 
                                  + "TF and IDF needs to be computed before proceeding.");
                    }
                }
            }
            else
                view.show("There is no categories to calculate TF*IDF");
        }


        public void onBtnSaveClicked()
        {
            interactor.saveToJsonFile();
            view.show("Successfully saved");
        }

        public void onBtnLoadTextFromFileClicked()
        {
            /*
             * open explorer to choose a file. It freezes all the process until the OK button will be pressed.
             * "false" means that user pressed "Cancel"
             */
            if (interactor.openFileDialog())
            {
                string text = interactor.readTextFromFile();
                view.loadEditableText(text);
            }
        }

    }
}
