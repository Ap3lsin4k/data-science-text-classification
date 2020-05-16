using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer.presentation
{
    interface CategoriesView
    {
        void show(string tip);

        void clearLongDebugMessage();//todo delete
        void showLongDebugLog(string message);

        void setCategories(object[] categories);

        void loadEditableText(string richText);
        
    }
}
