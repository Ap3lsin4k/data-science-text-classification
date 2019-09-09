using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class DE // with DE parameters.
    {
        Dictionary<string, Aword> samewords = new Dictionary<string, Aword>();

//        Dictionary<string, int> wordK;

        DE(string word, int n)
        {
            samewords[word].Add(new Aword(n));
            this.word = word;
            this.n = n;
//            this.k = k;
            if (wordK.ContainsKey(word))
                wordK[word] += 1;
            else
                wordK[word] = 1;
        }

        /*
         let "sport" is our key word. This class contain a word "sport" with list of keys and n
         */
    }
}
