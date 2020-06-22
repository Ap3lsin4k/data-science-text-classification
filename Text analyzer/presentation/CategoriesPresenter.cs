using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_analyzer.model.interactor;

namespace Text_analyzer.presentation
{
    class CategoriesPresenter
    {

       // TextJsonRepository newsJson;
        CategoriesView view;
        CategoriesInteractor interactor;


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

            string toOutToLbWords = "Peeled text:\n", toPrintInLbLong = "TF\n";


            view.clearLongDebugMessage();


            if (!string.IsNullOrWhiteSpace(textToBeAnalyzed))
            {
                // create new category, if it wasn't
                interactor.addCategory(catg, interactor.getSplitStrings(textToBeAnalyzed).ToList<string>()); // TODO test: test time for List-casting
                
                foreach (string word in interactor.getAllWordsFromShelf(catg))
                {
                    toOutToLbWords += word + "\n";

                }

                // save only unique words
                interactor.uniquifyWordsIn(catg); 


                // TF
                foreach (KeyValuePair<string, int> item in interactor.getUniqueWordsOrderByDescending(catg))
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
                if (interactor.whetherCategoryExist(catg))
                {
                    foreach (string word in interactor.getAllWordsFromShelf(catg))
                    {
                        toOutToLbWords += word + "\n";

                    }
                    foreach (KeyValuePair<string, int> item in interactor.getUniqueWordsOrderByDescending(catg))
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
            int categories = 0;
            //foreach (WordFreq text in library.Values)

            foreach (string word in interactor.getUniqueWords(catg))
            {
                categories = 1;
                foreach (KeyValuePair<string, WordFreq> text in interactor.getLibrary())
                {
                    if (text.Key == catg) continue;

                    if (text.Value.n.Keys.Contains(word))
                    {
                        categories++; // if at least a word is in other category we count it and go to another text
                        //break; // don't write break.
                    }

                }
                textToOut += word + ":" +
                interactor.calculateIdf(catg, word, categories).ToString("0.####")  // word, Number of all library, Number of text which contain this word
                + "\n";
                /* IDF*/
            }

            if (log) view.showLongDebugLog(textToOut);
        }


        public void onBtnIdfClicked(string currectCategory)
        {

            view.showLongDebugLog("IDF chose existed category to see more\n");
            
            string catg = currectCategory; //tbCategoryName.Text; // category

            if (interactor.getNumberOfShelfsInLibrary() != 0)
            {
                // calculate IDF for each category
                foreach (KeyValuePair<string, WordFreq> text in interactor.getLibrary())
                {
                    // write log if category is current.
                    idf(text.Key, text.Key == catg);
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

            if (interactor.getNumberOfShelfsInLibrary() != 0)
            {

                // TODO simplify KeyValuePair<> to string
                foreach (KeyValuePair<string, WordFreq> text in interactor.getLibrary())
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
