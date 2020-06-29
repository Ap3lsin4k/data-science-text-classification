using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilIsNotStudent.presentation
{
    interface CategoriesView
    {
        // common
        void show(string tip);
        void setCategories(string[] categories);


        void clearLongDebugMessage();
        void showLongDebugLog(string message);


        //from file
        void loadEditableText(string richText);
        
    }
}
