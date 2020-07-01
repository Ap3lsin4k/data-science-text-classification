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

            string toPrintInLbLong = "TF\n";


            view.clearLongDebugMessage();


            //feature if the field is not empty then learn
            if (!string.IsNullOrWhiteSpace(textToBeAnalyzed))
            {
                /*
                 * create new category &save only unique words
                 * rewrite if category already exists
                */
                interactor.addCategory(catg, interactor.getSplitWords(textToBeAnalyzed)); // TODO test: test time for List-casting
                


                // TF
                foreach (KeyValuePair<string, uint> item in interactor.getUniqueWordsOrderByDescending(catg))
                {
                    // do something with item.Key and item.Value
                    // TODO let the view do the concatenation
                    toPrintInLbLong += item.Key + " : " + interactor.howManyTimesWordAppear(catg, item.Key) + ",    "
                        + Math.Round(
                            interactor.calculateTf(catg, item.Key),
                            2)  // numbers after point
                        + "%" + "\n";
                }

                
                view.showLongDebugLog(toPrintInLbLong);

                view.setCategories(interactor.getCategories());
            }
            else
            {
                //feature if the textBox is empty then show saved data

                if (interactor.whetherCategoryExist(catg))
                {
                    foreach (KeyValuePair<string, uint> item in interactor.getUniqueWordsOrderByDescending(catg))
                    {
                        // do something with item.Key and item.Value
                        toPrintInLbLong += item.Key + " : " + Math.Round(
                                interactor.getTf(catg, item.Key),
                                2)  // numbers after point
                            + "%" + "\n";
                    }
                    view.showLongDebugLog(toPrintInLbLong);
                }
                else
                {
                    view.show("The category \"" + catg + "\" was not created. To create this category enter text of news in the TextBox");
                }

            }
        }


        
        private void idf(string catg, bool log)
        {
            string textToOut = "IDF\n";
            //foreach (WordFreq text in library.Values)

            foreach (string word in interactor.getUniqueWords(catg))
            {

                textToOut += word + ":" 
                                  + interactor.IDFForOtherCategories(catg, word).ToString("0.####")
                                  + "\n";
               
            }

            if (log) view.showLongDebugLog(textToOut);
        }


        public void onBtnIdfClicked(string currentCategory)
        {

            view.showLongDebugLog("IDF chose existed category to see more\n");
            
            if (interactor.getNumberOfShelvesInLibrary() != 0)
            {
                // calculate IDF for each category
                foreach (KeyValuePair<string, Book> text in interactor.getLibrary())
                {
                    // write log if category is current.
                    idf(text.Key, text.Key == currentCategory);
                }
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
            if (log) view.showLongDebugLog(toOutLbBig);
        }


        public void onBtnTfidfClicked(string catg)
        {
            view.showLongDebugLog("TFIDF please chose existed category to see more\n");

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
