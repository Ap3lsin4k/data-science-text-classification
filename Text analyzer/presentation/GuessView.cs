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


        void loadEditableText(string richText);


        void clearPreviousResults();
        void sortThroughResultsByTfidf();


    }
}
