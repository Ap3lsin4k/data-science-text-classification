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
using PupilIsNotStudent.presentation;
using PupilIsNotStudent.model;


namespace PupilIsNotStudent
{
    public partial class MainWindow : Form, CategoriesView, GuessView
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
                    new model.repository.AkinatorRepository(), 
                    new model.repository.TextParsingRepository(),
                            new model.repository.FileRepository(),
                            new model.repository.LogRepository(),
                            in textJson
                        )
                );
        }

        //==========COMMON==========

        public void show(string tip)
        {
            MessageBox.Show(tip);
        }

        public void setCategories(string[] categories)
        {
            cbCategories.Items.Clear();
            cbCategories.Items.AddRange(categories);
        }


        //==========CATEGORIES VIEW==========

        //==========CATEGORIES VIEW IMPLEMENTATION==========

        
        void CategoriesView.loadEditableText(string richText)
        {
            rtbKnownText.Text = richText;
        }

        // ==========USER ACTIONS==========
        private void btnTf_Click(object sender, EventArgs e)
        {
            _categPresenter.onBtnTfClicked(cbCategories.Text, rtbKnownText.Text);
          
        }

        private void btnIdf_Click(object sender, EventArgs e)
        {
            _categPresenter.onBtnIdfClicked(cbCategories.Text);
        }


        private void btnTfIdf_Click(object sender, EventArgs e)
        {
            _categPresenter.onBtnTfidfClicked(cbCategories.Text);
        }


        private void btnCategories_LoadTextFromFile_Click(object sender, EventArgs e)
        {
            _categPresenter.onBtnLoadTextFromFileClicked();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _categPresenter.onBtnSaveClicked();
        }





        //      ==========GUESS VIEW==========
        
        //==========GUESS VIEW IMPLEMENTATION==========

        void GuessView.loadEditableText(string richText)
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

        public void showLongDebugLogDe(string deResults)
        {
            lbDEresult.Text = "DE\n" + deResults;
        }

        public void initializeNewRow()
        {
            _currentRowInMyGridIndex = myGrid.Rows.Add();
        }

        public void showCategoryNameInCurRow(string categoryName)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[0].Value = categoryName;  // category
        }

        public void showTfidfInCurRow(double tfidfScore)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[1].Value = tfidfScore;
        }

        public void showDeInCurRow(double deScore)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[2].Value = deScore;
        }

        public void showTotalScoreInCurRow(double probabilityOfAffiliation)
        {
            myGrid.Rows[_currentRowInMyGridIndex].Cells[3].Value = probabilityOfAffiliation;
        }




        // ==========USER ACTIONS==========

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            _guessPresenter.onBtnGuessCategoryClicked(richTBtoAnalyze.Text);
        }


        private void btnDE_Click(object sender, EventArgs e)
        {
            _guessPresenter.onBtnComputeDisperseEstimationClicked(richTBtoAnalyze.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _guessPresenter.onBtnLoadJsonClicked();
        }

        private void btnLoadTextFromFile_Click(object sender, EventArgs e)
        {
            _guessPresenter.onBtnLoadTextFromFileClicked();

        }



    }
}