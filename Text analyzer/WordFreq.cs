using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class WordFreq // an news, an text
    {

        public Dictionary<string, int> n;  // frequency of apearing
        public Dictionary<string, double> TF;  // Term frequency
        public Dictionary<string, double> IDF;  // Inverse document frequency
        public Dictionary<string, double> TFIDF;  // Term frequency – Inverse document frequency

        public bool flagTf, flagIdf;  // true when TF, IDF is calculated

        public List<string> allWords;

        public WordFreq() // constructor to deserialize json
        {
            n = new Dictionary<string, int>();
            TF = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();
            allWords = new List<string>();
        }

        public WordFreq(List<string> words)  // constructor which program uses
        {
            n = new Dictionary<string, int>();
            TF = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();
            allWords = new List<string>();


            for (int i = 0; i < words.Count; ++i)
            {
                if (words[i] != "")  // to delete empty elements
                    allWords.Add(words[i]);
            }
        }

        public double calcTf(string key)
        {
            flagTf = true;
            TF[key] = 100.0 * n[key] / allWords.Count; // to find TF in percentes
            // implicit cast (int) to (double), for make normal division
            return TF[key];
        }

        public double calcIdf(string key, int D, int t) 
        {
            flagIdf = true;
            /*
            base 10 logarithm of (
                total number of documents in the colection (D)
                divided by
                number of documents where the word appears (t)
            )
            */
            IDF[key] = Math.Log10((float)D / (float)t); 
            return IDF[key];
        }

        public void calcTfIdf() // inverse document frequency
        {
            foreach (string word in n.Keys)
                TFIDF[word] = TF[word] * IDF[word];  // TF-IDF = TF*IDF
        }
    }
}