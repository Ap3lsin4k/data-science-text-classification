using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer.presentation
{
    interface GuessView
    {
        void show(string message);

        void setCategories(object[] categories);

        void loadEditableText(string richText);


        void clearPreviousResults();
        void sortThroughResultsByTfidf();


        // Disperse Estimation values and words
        void showLongDebugLogDe(string deResults);

        void initializeNewRow(); // myGrid.Rows.Add()
        void showCategoryNameInCurRow(string categoryName); //  myGrid.Rows[ind].Cells[0].Value = category.Key;  // category
        void showTfidfInCurRow(double tfidfScore);
        void showDeInCurRow(double deScore);
        void showTotalScoreInCurRow(double probabilityOfAffiliation);
    }
}
