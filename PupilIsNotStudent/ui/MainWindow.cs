using System;
using System.ComponentModel;
using System.Windows.Forms;
using PupilIsNotStudent.presentation;
using PupilIsNotStudent.model.core;


namespace PupilIsNotStudent
{
    public partial class MainWindow : Form, ICategoriesView, IGuessView
    {

      
private readonly CategoriesPresenter _categPresenter; // for the first view
private readonly GuessPresenter _guessPresenter; // for the second view

        private int _currentRowInMyGridIndex;
        //we compare from the most key index

        public MainWindow()
        {
            InitializeComponent();

            var textJson = new model.repository.ExtractKeyWordsRepository();
            _categPresenter = new CategoriesPresenter(this,
                    new model.interactor.CategoriesInteractor(
                            new model.repository.TextParsingRepository(),
                            new model.repository.FileRepository(),
                            in textJson
                        )
                );

            _guessPresenter = new GuessPresenter(this, 
                new model.interactor.GuessInteractor(
                    new PredictService(), 
                    new model.repository.TextParsingRepository(),
                            new model.repository.FileRepository(),
                    in textJson
                        )
                );
        }

        //==========COMMON==========

        public void Show(string tip)
        {
            MessageBox.Show(tip);
        }

        public void SetCategoryNames(string[] categories)
        {
            cbCategories.Items.Clear();
            cbCategories.Items.AddRange(categories);
        }


        //==========CATEGORIES VIEW==========

        //==========CATEGORIES VIEW IMPLEMENTATION==========

        
        void ICategoriesView.LoadEditableText(string richText)
        {
            rtbKnownText.Text = richText;
        }

        // ==========USER ACTIONS==========
        private void btnTf_Click(object sender, EventArgs e)
        {
            _categPresenter.OnBtnTermFrequencyClicked(cbCategories.Text, rtbKnownText.Text);
          
        }

        private void btnSaveAllCategories_Click(object sender, EventArgs e)
        {
            _categPresenter.OnSavingTrainDocsFinished();
            _categPresenter.OnBtnInverseDocumentFrequencyClicked();
            _categPresenter.OnBtnTermFrequencyInverseDocumentFrequencyClicked();
        }


        private void btnFindKeywordsFromFiles_Click(object sender, EventArgs e)
        {
        }


        private void btnCategories_LoadTextFromFile_Click(object sender, EventArgs e)
        {
            _categPresenter.OnFitTermFreqInverseDocFreqFromFolder();
        }





        //      ==========GUESS VIEW==========
        
        //==========GUESS VIEW IMPLEMENTATION==========

        void IGuessView.LoadEditableText(string richText)
        {
            richTBtoAnalyze.Text = richText;
        }

        public void ClearPreviousResults()
        {
            myGrid.Rows.Clear();
        }

        public void SortThroughResultsByTfidf()
        {
            // 0 - Name, 1 - TFIDF, 2 - DE, 3 - DE*TFIDF
            myGrid.Sort(myGrid.Columns[1], ListSortDirection.Descending);
        }

        public void ShowLongDebugLogDe(string deResults)
        {
            lbDEresult.Text = "DE\n" + deResults;
        }

        public void InitializeNewRow()
        {
            _currentRowInMyGridIndex = myGrid.Rows.Add();
        }

        public void ShowCategoryNameInCurRow(string categoryName)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[0].Value = categoryName;  // category
        }

        public void ShowTfidfInCurRow(double tfidfScore)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[1].Value = tfidfScore;
        }

        public void ShowDeInCurRow(double deScore)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[2].Value = deScore;
        }

        public void ShowTotalScoreInCurRow(double probabilityOfAffiliation)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[3].Value = probabilityOfAffiliation;
        }




        // ==========USER ACTIONS==========

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            _guessPresenter.OnBtnGuessCategoryClicked(richTBtoAnalyze.Text);
        }


        private void btnDE_Click(object sender, EventArgs e)
        {
            _guessPresenter.OnBtnComputeDisperseEstimationClicked(richTBtoAnalyze.Text);
        }

        private void btnLoadTextFromFile_Click(object sender, EventArgs e)
        {
            _guessPresenter.OnBtnLoadTextFromFileClicked();

        }



    }
}