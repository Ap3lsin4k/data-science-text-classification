﻿using System;
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
using Text_analyzer.automated_testing;

namespace Text_analyzer
{
    public partial class UnitTestFormGuess : Form, GuessView
    {

        //==========CATEGORIES VIEW==========
        // category, and words in each text
//        Dictionary<string, WordFreq> library = new Dictionary<string, WordFreq>();
        int currentRowInMyGridIndex;
        //we compare from the most key index
        private UnitTestDriver unitTestDriver;

        public UnitTestFormGuess()
        {
            unitTestDriver = new UnitTestDriver(this);
            InitializeComponent();
            unitTestDriver.Test1();
        }


        //      ==========GUESS VIEW==========
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
            
            // UNIT TEST
            MessageBox.Show(myGrid.Rows[0].Cells[0].Value.ToString());
            String Msg;
            Msg = "Message";
            unitTestDriver.CheckEquals("Спрт", myGrid.Rows[0].Cells[0].Value.ToString(), ref Msg);
            
        }

        

        public void showLongDebugLogDe(string deResults)
        {
            lbDEresult.Text = "DE\n"+deResults;
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

        public void show(string message)
        {
            MessageBox.Show(message);
        }

        public void setCategories(object[] categories)
        {
            MessageBox.Show("onCall_setCategories");
        }
    }
}