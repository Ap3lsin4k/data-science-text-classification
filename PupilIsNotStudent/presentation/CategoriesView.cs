using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilIsNotStudent.presentation
{
    interface CategoriesView
    {
        void show(string tip);

        void clearLongDebugMessage();
        void showLongDebugLog(string message);

        void setCategories(string[] categories);

        void loadEditableText(string richText);
        
    }
}
