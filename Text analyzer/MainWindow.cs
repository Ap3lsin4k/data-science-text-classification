using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
// work with files
using System.IO;
using Text_analyzer.presentation;
using Text_analyzer.model;


namespace Text_analyzer
{
    public partial class MainWindow : Form, CategoriesView, GuessView
    {

        //==========CATEGORIES VIEW==========
        // category, and words in each text
//        Dictionary<string, WordFreq> library = new Dictionary<string, WordFreq>();
        CategoriesPresenter categPresenter; // for the first view
        GuessPresenter guessPresenter; // for the second view
        int currentRowInMyGridIndex;
        //we compare from the most key index


        public MainWindow()
        {
            InitializeComponent();

            model.repository.TextJsonRepository textJson = new model.repository.TextJsonRepository();
            categPresenter = new CategoriesPresenter(this, 
                    new model.interactor.CategoriesInteractor(
                            new model.repository.TextRepository(),
                            new model.repository.FileRepository()
                        ), 
                    ref textJson
                );

            guessPresenter = new GuessPresenter(this,
                    new model.interactor.GuessInteractor(
                            new model.repository.TextRepository(),
                            new model.repository.FileRepository(),
                            new model.repository.LogRepository(),
                            new model.repository.TextJsonRepository()
                        ),
                    ref textJson
                );
        }
        //==========CATEGORIES VIEW IMPLEMENTATION==========
        public void show(string tip)
        {
            MessageBox.Show(tip);
        }

        public void clearLongDebugMessage()
        {
            lbBig.Text = "";
        }

        public void showLongDebugLog(string message)
        {
            lbBig.Text = message;
        }

        public void setCategories(object[] categories)
        {
            cbCategories.Items.Clear();
            cbCategories.Items.AddRange(categories);
        }
        
        void CategoriesView.loadEditableText(string richText)
        {
            rtbKnownText.Text = richText;
        }

        // ==========USER ACTIONS==========
        private void btnTf_Click(object sender, EventArgs e)
        {
            categPresenter.onBtnTfClicked(cbCategories.Text, rtbKnownText.Text.ToString());
          
        }

        private void btnIdf_Click(object sender, EventArgs e)
        {
            categPresenter.onBtnIdfClicked(cbCategories.Text);
        }


        private void btnTfIdf_Click(object sender, EventArgs e)
        {
            categPresenter.onBtnTfidfClicked(cbCategories.Text);
        }


        private void btnCategories_LoadTextFromFile_Click(object sender, EventArgs e)
        {
            categPresenter.onBtnLoadTextFromFileClicked();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            categPresenter.onBtnSaveClicked();
        }





        //      ==========GUESS VIEW==========
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            myGrid.Rows.Add();
            guessPresenter.onBtnGuessCategoryClicked(richTBtoAnalyze.Text);
        }


        public void loadEditableText(string richText)
        {
            richTBtoAnalyze.Text = richText;
        }

        public void clearPreviousResults()
        {
            myGrid.Rows.Clear();
        }

        public void sortThroughResultsByTfidf()
        {
            // 0 - Name, 1 - TFIDF, 2 - DE, 3 - DE*TFIDF
            myGrid.Sort(myGrid.Columns[1], ListSortDirection.Descending);

        }


        private void btnDE_Click(object sender, EventArgs e)
        {
            guessPresenter.onBtnComputeDisperseEstimationClicked(richTBtoAnalyze.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            guessPresenter.onBtnLoadJsonClicked();
        }
        

       
        private void btnLoadTextFromFile_Click(object sender, EventArgs e)
        {
            guessPresenter.onBtnLoadTextFromFileClicked();

        }

        public void showLongDebugLogDe(string deResults)
        {
            lbDEresult.Text = deResults;
        }

        public void initializeNewRow()
        {
            currentRowInMyGridIndex = myGrid.Rows.Add();
        }

        public void showCategoryNameInCurRow(string categoryName)
        {
            myGrid.Rows[currentRowInMyGridIndex].Cells[0].Value = categoryName;  // category
        }

        public void showTfidfInCurRow(double tfidfScore)
        {
            myGrid.Rows[currentRowInMyGridIndex].Cells[1].Value = tfidfScore;
        }

        public void showDeInCurRow(double deScore)
        {
            myGrid.Rows[currentRowInMyGridIndex].Cells[2].Value = deScore;
        }

        public void showTotalScoreInCurRow(double probabilityOfAffiliation)
        {
            myGrid.Rows[currentRowInMyGridIndex].Cells[3].Value = probabilityOfAffiliation;
        }
    }
}


/*
    Кирилиця Десятковий код Шістнадцятеричний код Символ Символьне позначення Ё Ё Ё А А А Б Б Б В В В Г Г Г Д Д Д Е Е Е Ж Ж Ж З З З И И И Й Й Й К К К Л Л Л М М М Н Н Н О О О П П П Р Р Р С С С Т Т Т У У У Ф Ф Ф Х Х Х Ц Ц Ц Ч Ч Ч Ш Ш Ш Щ Щ Щ Ъ Ъ Ъ Ы Ы Ы Ь Ь Ь Э Э Э Ю Ю Ю Я Я Я а а а б б б в в в г г г д д д е е е ж ж ж з з з и и и й й й к к к л л л м м м н н н о о о п п п р р р с с с т т т у у у ф ф ф х х х ц ц ц ч ч ч ш ш ш щ щ щ ъ ы ь э ю я ё 
                  if(1040 <= letterCode && letterCode <= 1103)
                {

                    peeledText += sumbol;
                }   
*/
/*
 * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_analyzer
{
    public partial class Form1 : Form
    {

        private string peeledText = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            string news = rtbKnownText.Text.ToString();

            lbRawNews.Text = "";
            peeledText = "";
            foreach (char sumbol in news)
            {
                int letterCode = (int)sumbol;
                lbRawNews.Text = lbRawNews.Text + letterCode + " ";
                peeledText += sumbol;
            }

            MessageBox.Show(peeledText);
        }



        private bool isCyrillic(int letterCode)
        {
                    

        }
    }
}

/*
    Кирилиця Десятковий код Шістнадцятеричний код Символ Символьне позначення Ё Ё Ё А А А Б Б Б В В В Г Г Г Д Д Д Е Е Е Ж Ж Ж З З З И И И Й Й Й К К К Л Л Л М М М Н Н Н О О О П П П Р Р Р С С С Т Т Т У У У Ф Ф Ф Х Х Х Ц Ц Ц Ч Ч Ч Ш Ш Ш Щ Щ Щ Ъ Ъ Ъ Ы Ы Ы Ь Ь Ь Э Э Э Ю Ю Ю Я Я Я а а а б б б в в в г г г д д д е е е ж ж ж з з з и и и й й й к к к л л л м м м н н н о о о п п п р р р с с с т т т у у у ф ф ф х х х ц ц ц ч ч ч ш ш ш щ щ щ ъ ы ь э ю я ё 
     
*/
