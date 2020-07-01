using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                
                interactor.updateTF(catg);
                

                view.setCategories(interactor.getCategories());
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


        
        private void idf(string shelf)
        {
           
            //foreach (WordFreq text in library.Values)
            /*
            foreach (string word in interactor.getUniqueWords(catg))
            {

                textToOut += word + ":" 
                                  + interactor.IDFForOtherCategories(catg, word).ToString("0.####")
                                  + "\n";
               
            }*/

        }


        public void onBtnIdfClicked(string currentCategory)
        {

            view.show("IDF chose existed category to see more\n");
            
            if (interactor.getNumberOfShelvesInLibrary() != 0)
            {
                // calculate IDF for each category
                interactor.IDFForEachBook();
            }
            else
                view.show("Here is no categories to calculate the Inverse Document Frequency");
        }

        private void tfIdf(string catg, bool log)
        {
            string toOutLbBig = "TFIDF\n";

            interactor.calculateTfIdf(catg);

            foreach (KeyValuePair<string, double> wordTI in interactor.getTfIdfOrderByDescending(catg))
            {
                toOutLbBig += wordTI.Key + " : " + (wordTI.Value).ToString("0.####") + "\n"; ;
            }
        }


        public void onBtnTfidfClicked(string catg)
        {

            if (interactor.getNumberOfShelvesInLibrary() != 0)
            {

                // TODO simplify KeyValuePair<> to string
                foreach (KeyValuePair<string, Book> text in interactor.getLibrary())
                {
                    if (interactor.tfExist(text.Key) && interactor.idfExist(text.Key))
                    {
                        tfIdf(text.Key, text.Key == catg);
                    }
                    else
                    {
                        view.show("Error. Please click TF for \"" + catg + "\" category. " +
                            "Than you should click on IDF. " +
                            "Finally click TFIDF to get it");
                    }
                }
            }
            else
                view.show("Here is no categories to calculate TF*IDF");
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
