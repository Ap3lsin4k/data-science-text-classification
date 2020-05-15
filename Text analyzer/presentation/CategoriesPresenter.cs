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
        model.interactor.CategoriesInteractor interactor;


        public CategoriesPresenter(CategoriesView view, CategoriesInteractor interactor, TextJson newsJson) {
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
                view.print("Please enter or chose the category");
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
                view.setLongDebug(toOutToLbBig);

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
                    view.setLongDebug(toOutToLbBig);
                }
                else
                {
                    view.print("The category \"" + catg + "\" was not created. To create this category enter text of news in the TextBox");
                }

            }
        }

        public void onBtnIdfClicked()
        {

        }

        public void onBtnTfidfClicked()
        {

        }

        public void onBtnSaveClicked()
        {

        }

        public void onBtnLoadTextFromFileClicked()
        {

        }

    }
}
