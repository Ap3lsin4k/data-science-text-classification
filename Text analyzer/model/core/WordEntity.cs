using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    // Todo move to repository layer
    class WordEntity // an news, an text
    {
        public Dictionary<string, int> n;  // <word, frequency of apearing>, todo change int to unsigned int or something
        public Dictionary<string, double> TF;  // <word, Term frequency in %>
        public Dictionary<string, double> IDF;  // <word, Inverse document frequency>
        public Dictionary<string, double> TFIDF;  // <word, Term frequency – Inverse document frequency>
        DE DE;

        public List<string> allWords;

        private void initialize()
        {
            n = new Dictionary<string, int>();
            TF = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();
            DE = new DE();
            allWords = new List<string>();
        }
        public WordEntity() // constructor to deserialize json
        {
            initialize();
        }

        public WordEntity(List<string> words)  // constructor for common use
        {
            initialize();

            allWords = words;
        }

        public double calcTf(string key)
        {
            TF[key] = 100.0 * n[key] / allWords.Count; // to find TF in percentes
            // implicit cast (int) to (double), to make normal division
            return TF[key];
        }

        public double calcIdf(string key, int D, int t) // t is always <= D
        {
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

        
        public void calcDe()  //Disperse Evaluation
        {
            DE.mainFormula();
        }
    }
}