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

        TextJson newsJson;
        CategoriesView view;
        CategoriesInteractor interactor;


        public CategoriesPresenter(CategoriesView view, CategoriesInteractor interactor, ref TextJson newsJson) {
            this.view = view;
            this.interactor = interactor;
            this.newsJson = newsJson;
        }

        public void onBtnTfClicked(string category, string textToBeAnalyzed)
        {
            // calculate TF to all categories and then press IDF. Then TFIDF.

            // newsJson = new TextJson();
            string catg = category;//tbCategoryName.Text; // category

            if (string.IsNullOrWhiteSpace(catg))
            {
                view.show("Please enter or chose the category");
                return;
            }

            string toOutToLbWords = "Peeled text:\n", toOutToLbBig = "TF\n";


            view.clearLongDebugMessage();


            if (!string.IsNullOrWhiteSpace(textToBeAnalyzed))
            {
                string peeledText = interactor.getRawText(textToBeAnalyzed);

                // create text with new category, if it wasn't created still
                newsJson.texts[catg] = new WordFreq(peeledText.Split().ToList<string>());  // TODO test: casting to List can take much time

                foreach (string word in newsJson.texts[catg].allWords)
                {
                    toOutToLbWords += word + "\n";

                }
                foreach (string word in newsJson.texts[catg].allWords)
                {
                    if (newsJson.texts[catg].n.ContainsKey(word))
                    {
                        ++newsJson.texts[catg].n[word];
                    }
                    else
                    {
                        newsJson.texts[catg].n[word] = 1;
                    }

                }


                // TF
                foreach (KeyValuePair<string, int> item in newsJson.texts[catg].n.OrderByDescending(key => key.Value))
                {
                    // do something with item.Key and item.Value
                    toOutToLbBig += item.Key + " : " + newsJson.texts[catg].n[item.Key] + ",    "
                        + Math.Round(
                            newsJson.texts[catg].calcTf(item.Key),
                            2)  // numbers after point
                        + "%" + "\n";
                }

                view.showLongDebugLog(toOutToLbBig);

                view.setCategories(newsJson.texts.Keys.ToArray());
            }
            else
            {
                if (newsJson.texts.ContainsKey(catg))
                {
                    foreach (string word in newsJson.texts[catg].allWords)
                    {
                        toOutToLbWords += word + "\n";

                    }
                    foreach (KeyValuePair<string, int> item in newsJson.texts[catg].n.OrderByDescending(key => key.Value))
                    {
                        // do something with item.Key and item.Value
                        toOutToLbBig += item.Key + " : " + Math.Round(
                                newsJson.texts[catg].TF[item.Key],
                                2)  // numbers after point
                            + "%" + "\n";
                    }
                    view.showLongDebugLog(toOutToLbBig);
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
            //foreach (WordFreq text in texts.Values)

            foreach (string word in newsJson.texts[catg].n.Keys)
            {
                categories = 1;
                foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)
                {
                    if (text.Key == catg) continue;

                    if (text.Value.n.Keys.Contains(word))
                    {
                        categories++; // if at least a word is in other category we count it and go to another text
                        //break; // don't write break.
                    }

                }
                textToOut += word + ":" +
                newsJson.texts[catg].calcIdf(word, newsJson.texts.Count, categories).ToString("0.####")  // word, Number of all texts, Number of text which contain this word
                + "\n";
                /* IDF*/
            }

            if (log) view.showLongDebugLog(textToOut);
        }


        public void onBtnIdfClicked(string currectCategory)
        {

            view.showLongDebugLog("IDF chose existed category to see more\n");
            
            string catg = currectCategory; //tbCategoryName.Text; // category

            if (newsJson.texts.Count != 0)
            {
                // calculate IDF for each category
                foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)
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

            newsJson.texts[catg].calcTfIdf();

            foreach (KeyValuePair<string, double> wordTI in newsJson.texts[catg].TFIDF.OrderByDescending(key => key.Value))
            {
                toOutLbBig += wordTI.Key + " : " + (wordTI.Value).ToString("0.####") + "\n"; ;
            }
            if (log) view.showLongDebugLog(toOutLbBig);
        }


        public void onBtnTfidfClicked(string catg)
        {
            view.showLongDebugLog("TFIDF please chose existed category to see more\n");

            if (newsJson.texts.Count != 0)
            {

                // TODO simplify KeyValuePair<> to string
                foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)
                {
                    if (newsJson.texts[text.Key].flagTf && newsJson.texts[text.Key].flagIdf)
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
            newsJson.save();
            /*FileInfo f = new FileInfo("Mytext.txt");
            StreamWriter logCommonWords = f.CreateText();
            logCommonWords.WriteLine("This is from");
            logCommonWords.WriteLine("Chapter 6");
            logCommonWords.WriteLine("Of C# Module");
            logCommonWords.Write(logCommonWords.NewLine);
            logCommonWords.WriteLine("Thanks for your time");
            logCommonWords.Close();*/
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
