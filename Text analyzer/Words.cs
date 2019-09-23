using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class Words
    {
        //legacy
        List<DE> ListDE = new List<DE>();

        //             lemmatizated word
        public void addAWord(string bareword, int n)
        {
            //get k-1 word
           // DE previousWord = new DE(bareword, n);
            DE A = new DE();
            ListDE.Add(A);
        }
    }
}
