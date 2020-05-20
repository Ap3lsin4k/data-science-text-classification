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
        TextJson newsJson;

        public GuessPresenter(GuessView view, GuessInteractor interactor, ref TextJson json)
        {
            this.view = view;
            this.interactor = interactor;
            this.newsJson = json;
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
            string[] unknownWords = interactor.splitToWords(textToBeAnalyzed);
            view.clearPreviousResults();

            // Do not repeat words
            
            onBtnComputeDisperseEstimationClicked(textToBeAnalyzed);

            foreach (KeyValuePair<string, WordFreq> category in newsJson.texts)  // category, a category properties
            {
                // here we have Category(category.Key) and array of unrepeated words(category.Value.allWords)
                // also, there is array of repeated words(unknownWords)
              
                view.initializeNewRow();
                view.showCategoryNameInCurRow(category.Key);
                interactor.openNewLogFile(category.Key);

                //computeAffiliationOfTextToCategory

                //                myGrid.Rows[ind].Cells[1].Value = countOfCommonElem;

                // myGrid.Rows[ind].Cells[1].Value = Math.Round(tfidfTotalScore, 4);//Math.Round(100.0 * countOfCommonElem / Math.Min(category.Value.TFIDF.Count, keyWordsLimit), 1);
                //(float)100 * countOfCommonElem / (n.Count);  // percent

                view.showTfidfInCurRow(Math.Round(tfidfTotalScore, 4));

                
                if (isDeNotFound)
                {
                    view.show("The key(s) " + lastErrorKey + " was not found in the Dictionary of DispersionEstimation");
                }
                else
                {
                    view.showDeInCurRow(Math.Round(deScore, 4));
                    view.showTotalScoreInCurRow(Math.Round(tfidfTotalScore * deScore, 4));

                }
                // end writing log
                interactor.closeLogFile();
            }

            // sorting by importance coefficent
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

        public void onBtnComputeDisperseEstimationClicked(string textToBeAnalyzed)
        {
            // string peeledText = getRawText(richTBtoAnalyze.Text.ToString());//todo optimise speed
            string resultOfDispersionEstimation = myDe.analyzeDE(interactor.getRawTextSplit(textToBeAnalyzed));
            view.showLongDebugLog(resultOfDispersionEstimation.ToString());
        }



        private bool load()
        {
            bool success;
            success = newsJson.load();
            view.setCategories(newsJson.texts.Keys.ToArray());
            return success;
        }


    }
}
