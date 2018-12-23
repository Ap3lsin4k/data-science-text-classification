using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class WordFreq // an news, an text
    {

        public Dictionary<string, int> n;  // частота входжень обраного слова
        public Dictionary<string, double> TF;
        public Dictionary<string, double> IDF;
        public Dictionary<string, double> TFIDF;

        public bool flagTf, flagIdf;

        public string[] allWords;

        public WordFreq(string[] words)
        {
            n = new Dictionary<string, int>();
            TF = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            allWords = words;
        }

        public double getTf(string key)
        {
            flagTf = true;
            TF[key] = Math.Round(100.0 *  // percent
                        n[key] / allWords.Length, // to find TF
                    2);  // numbers after coma
            return TF[key];
        }

        public double getIdf(string key, int D, int t) // inverse document frequency
        {
            flagIdf = true;
            IDF[key] = Math.Log10((float)D / (float)t);
            return IDF[key];
        }

        public string getTfIdf() // inverse document frequency
        {
            string toOutLbBig = "TFIDF\n";

            foreach (string word in n.Keys)
            {
                TFIDF[word] = TF[word] * IDF[word];
            }
            foreach (KeyValuePair<string, double> wordTI in TFIDF.OrderByDescending(key => key.Value))
            {
                toOutLbBig += wordTI.Key + " : " + (wordTI.Value).ToString("0.####") + "\n"; ;
            }

            return toOutLbBig;
        }
    }
}
