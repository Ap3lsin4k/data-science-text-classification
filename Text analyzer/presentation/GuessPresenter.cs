using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_analyzer.model.interactor;

namespace Text_analyzer.presentation
{
    class GuessPresenter
    {
        GuessView view;
        GuessInteractor interactor;
        const int keyWordsLimit = 155;
        DE myDe = new DE();

        public GuessPresenter(GuessView view, GuessInteractor interactor)
        {
            this.view = view;
            this.interactor = interactor;
            load();
        }


        public void onBtnLoadTextFromFileClicked()
        {
            if (interactor.openFileDialog())
            {
                view.loadEditableText(interactor.readTextFromFile());
            }
        }


        public void onBtnLoadJsonClicked()
        {
            if (load())
                view.show("Successfully loaded from \"analysis.json\"");
            // error message prints in the newsJson.load().catch
        }

        public void onBtnGuessCategoryClicked(string textToBeAnalyzed)
        {
            string unknownText = interactor.getRawText(textToBeAnalyzed);  // Text with unknown category
            string[] unknownWords = unknownText.Split();

            /* TODO clean up
            double wordsCount = 0, wordsCountAvg;

            foreach (WordFreq text in newsJson.texts.Values)
            {
                wordsCount += text.allWords.Count;
            }
            wordsCountAvg = wordsCount / newsJson.texts.Count;
            */
            view.clearPreviousResults();
            // all words repeat one time now
            Dictionary<string, int> n = new Dictionary<string, int>();
            foreach (string word in unknownWords)
            {
                if (n.ContainsKey(word)) ++n[word];
                else n[word] = 1;

            }
            onBtnComputeDisperseEstimationClicked();

            foreach (KeyValuePair<string, WordFreq> category in newsJson.texts)  // category, a category properties
            {
                // here we have Category(category.Key) and array of unrepeated words(category.Value.allWords)
                // on the other hand, we have array of repeated words(unknownWords)
                int ind = myGrid.Rows.Add(), countOfCommonElem = 0;
                double score = 0, deScore = 0;
                myGrid.Rows[ind].Cells[0].Value = category.Key;  // category

                Directory.CreateDirectory("log");
                FileInfo f = new FileInfo("log/" + category.Key + ".txt");
                StreamWriter logCommonWords = f.CreateText();
                bool isDeNotFound = false;
                string lastErrorKey = "";
                foreach (string word in n.Keys) // the unrepeated word in unknown category
                {
                    int break_counter = 0;
                    // more semantic comes first. від найбільш ключових слів до найменш  у категоріях
                    foreach (KeyValuePair<string, double> wordCategory in category.Value.TFIDF.OrderByDescending(key => key.Value))
                    {

                        break_counter++;
                        if (break_counter >= keyWordsLimit)
                        {
                            break;
                        }
                        //TFIDF unknown category word is wordCateg
                        if (word == wordCategory.Key) // if word from unknown category equals word from category we know
                        {
                            ;
                            ++countOfCommonElem;
                            score += wordCategory.Value;

                            // must be true DE
                            if (myDe.words.ContainsKey(wordCategory.Key))
                            {
                                deScore += myDe.words[word].dispersionEstimation;

                                logCommonWords.WriteLine(word + ", TFIDF: " + wordCategory.Value + ", DE: " + myDe.words[word].dispersionEstimation);
                            }
                            else
                            {
                                isDeNotFound = true;
                                lastErrorKey += '"' + word + "\", ";//for debug purposes
                            }

                        }
                        //MessageBox.Show(category.Key + " " + wordCategory.Value + ":"+ wordCategory.Key);

                    }

                }



                //                myGrid.Rows[ind].Cells[1].Value = countOfCommonElem;

                // myGrid.Rows[ind].Cells[1].Value = Math.Round(score, 4);//Math.Round(100.0 * countOfCommonElem / Math.Min(category.Value.TFIDF.Count, keyWordsLimit), 1);
                //(float)100 * countOfCommonElem / (n.Count);  // percent
                myGrid.Rows[ind].Cells[1].Value = Math.Round(score, 4); // imporotance coefficient

                if (isDeNotFound)
                {

                    MessageBox.Show("The key(s) " + lastErrorKey + "was not found in the Dictinary of DispersionEstimation");

                }
                else
                {

                    myGrid.Rows[ind].Cells[2].Value = Math.Round(deScore, 4); // imporotance coefficient
                    myGrid.Rows[ind].Cells[3].Value = Math.Round(score * deScore, 4); // imporotance coefficient

                }
                // end writing log
                logCommonWords.Close();
            }

            // sorting by importance coeffficent
            view.sortThroughResultsByTfidf();

            // TODO вставляти вже відсортовані данні
            // DataGridViewColumn newColumn =
            /*
            myGrid.Columns.GetColumnCount(
            DataGridViewElementStates.Selected)
            == 1
            ? myGrid.SelectedColumns[0]
             : null;
            //*/

            //ListSortDirection direction = ListSortDirection.Ascending;
            /*if (newColumn!= null)
                    myGrid.Sort(myGr, direction);
            else
                MessageBox.Show("Select a single column and try again.",
                "Error: Invalid Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Error);*/
        }

        public void onBtnComputeDisperseEstimationClicked()
        {
            // string peeledText = getRawText(richTBtoAnalyze.Text.ToString());//todo optimise speed
            string resultOfDispersionEstimation = myDe.analyzeDE(getRawTextSplit(richTBtoAnalyze.Text));
            lbDEresult.Text = resultOfDispersionEstimation.ToString();
        }



        private bool load()
        {
            bool success;
            success = newsJson.load();
            updateCbCategories();
            return success;
        }


    }
}
