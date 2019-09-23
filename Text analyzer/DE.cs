using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class DE
    {
        //TODO static
        private class NKavgA
        {
            public List<int> NKs = new List<int>();
            public double averageAs;
            public double sqAvgAs;


        }

        Dictionary<string, NKavgA> words;

        

        public DE()
        {
            this.words = new Dictionary<string, NKavgA>();
        }

        public void init(List<string> wordsToAnalyse)
        {
            int n = 1, k = 0;
            foreach (string aWord in wordsToAnalyse)
            {
                if (!words.ContainsKey(aWord))
                {
                    words[aWord] = new NKavgA();
                }
                words[aWord].NKs.Add(n);
                ++n;
            }
        }

        void addAwordNK()
        {

        }

        int deltaA(List<int> A, int k)
        {
            return A[k + 1] - A[k];  // m-n; where m, n are neighbor position of the "A" word
        }

        private int avgA()
        {
            /*1Dictionary<string, NKavgA>.ValueCollection*/ var ns = words;
           // int sum = 0, k=0;
            foreach (var word in words.Keys)// = 0; k < ns.NKs.Count - 1; ++k)
            {
                // if (k == words[word].NKs.Count - 1) break; // don't count the last element
                //  sum += deltaA(words[word].NKs, k);  // m-n
                //  ++k;
                int sum = 0;

                for (int k = 0; k < words[word].NKs.Count - 1; ++k)
                {
                    sum += deltaA(words[word].NKs, k);  // m-n
                }

                NKavgA average = new NKavgA();
                average.averageAs = sum / (words[word].NKs.Count - 1);
                words[word] = average; // 
            }



            //              
            /*foreach (NKavgA ns in words.Values)
            {
                //                var listNK = de.Value;
                int sum = 0;
                for (int k = 0; k < ns.NKs.Count - 1; ++k)
                {
                    sum += deltaA(ns.NKs, k);  // m-n
                }
//                ns.avarageAs = sum / (ns.NKs.Count - 1);  // error because foreach
                

            }*/
            return 0;
        }

        public void mainFormula()
        {
            avgA();
            //Math.Sqrt(avgA() * avgA()) / avgA();
        }

        public void analyzeDE(List<string> unknownCategoryWords)
        {
            init(unknownCategoryWords);   
        }
    }
}
