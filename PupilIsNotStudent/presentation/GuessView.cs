using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilIsNotStudent.presentation
{
    interface IGuessView
    {
        // common
        void Show(string message);
        void SetCategories(string[] categories);
        
        void LoadEditableText(string richText);


        void ClearPreviousResults();
        void SortThroughResultsByTfidf();


        // Disperse Estimation values and words
        void ShowLongDebugLogDe(string deResults);

        void InitializeNewRow(); // myGrid.Rows.Add()
        void ShowCategoryNameInCurRow(string categoryName); //  myGrid.Rows[ind].Cells[0].Value = category.Key;  // category
        void ShowTfidfInCurRow(double tfidfScore);
        void ShowDeInCurRow(double deScore);
        void ShowTotalScoreInCurRow(double probabilityOfAffiliation);
    }
}
