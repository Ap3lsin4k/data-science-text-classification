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
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.utils;


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

        public void SetCategories(string[] categories)
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

        private void btnIdf_Click(object sender, EventArgs e)
        {
            _categPresenter.OnBtnInverseDocumentFrequencyClicked(cbCategories.Text);
        }


        private void btnTfIdf_Click(object sender, EventArgs e)
        {
            _categPresenter.OnBtnTermFrequencyInverseDocumentFrequencyClicked(cbCategories.Text);
        }


        private void btnCategories_LoadTextFromFile_Click(object sender, EventArgs e)
        {
            _categPresenter.OnBtnLoadTextFromFileClicked();
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