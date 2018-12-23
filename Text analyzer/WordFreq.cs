using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class WordFreq
    {

        public Dictionary<string, int> n;  // частота входжень обраного слова
        public string[] allWords;

        public WordFreq(string[] words)
        {
            n = new Dictionary<string, int>();
            allWords = words;
        }

        public double getTf(string key)
        {
            return Math.Round(100.0 *  // percent
                        n[key] / allWords.Length, // to find TF
                    2);  // numbers after coma
        }
    }
}
