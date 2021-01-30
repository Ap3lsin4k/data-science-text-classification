using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilIsNotStudent.presentation
{
    interface ICategoriesView
    {
        // common
        void Show(string tip);
        void SetCategories(string[] categories);


        //from file
        void LoadEditableText(string richText);
        
    }
}
