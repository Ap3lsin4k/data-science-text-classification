using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer.presentation
{
    interface CategoriesView
    {
        void print(string tip);

        void clearLongDebugMessage();//todo delete
        void setLongDebug(string message);

        void setCategories(object[] categories);
        
    }
}
