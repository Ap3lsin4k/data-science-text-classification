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
            public double averageAs; // AVG(NKs[1]-NKs[0], NKs[2]-NKs[1],..., NKs[K]-NKs[K-1]) 
            public double sqAvgAs;  // AVG((NKs[1]-NKs[0])^2, (NKs[2]-NKs[1])^2, ..., (NKs[K]-NKs[K-1])^2)
            public double dispersionEstimation;
        }

        Dictionary<string, NKavgA> words;



        public DE()
        {
            this.words = new Dictionary<string, NKavgA>();
        }
        public void preinit()
        {
            // Clear dictionary to add new words
            this.words.Clear();
        }

        public void init(List<string> wordsToAnalyse)
        {
            int n = 1;
            foreach (string aWord in wordsToAnalyse)
            {
                if (!words.ContainsKey(aWord))
                {            // create new word
                    words[aWord] = new NKavgA();
                }
                // add the position of the next occurence of the word
                words[aWord].NKs.Add(n);
                ++n;// move text pivot to the next word
            }
        }


        int deltaA(List<int> A, int k)
        {
            return A[k + 1] - A[k];  // m-n; where m, n are neighbor position of the "A" word
        }

        private double avgA(string A)  // <ΔA> = AVG(ΔA, ΔA, ΔA...)
        {
            int sum = 0;

            for (int k = 0; k < words[A].NKs.Count - 1; ++k)
            {
                sum += deltaA(words[A].NKs, k);  // m-n
            }

            //save average A for each term
            if (words[A].NKs.Count - 1 != 0)
                words[A].averageAs = (double)sum / (words[A].NKs.Count - 1); // AVG = sum divided by number of variables(n)
            else
                words[A].averageAs = words.Count;

           
            return words[A].averageAs;
        }

        private double squareAvgA(string A) //<ΔA^2> = AVG(ΔA^2, ΔA^2, ΔA^2...)
        {
            int sum = 0;

            for (int k = 0; k < words[A].NKs.Count - 1; ++k)
            {
                int deltaMN = deltaA(words[A].NKs, k);
                sum += deltaMN * deltaMN;  // (m-n) squared
            }

            //save average A for each term
            if (words[A].NKs.Count - 1 != 0)
                words[A].sqAvgAs = (double)sum / (words[A].NKs.Count - 1); // AVG = sum divided by number of variables(n)
            else
                words[A].sqAvgAs = words.Count; // TODO fix for single words in text


            return words[A].sqAvgAs;
        }

        public double mainFormula()  //Math.Sqrt(<ΔA^2> - <ΔA>^2) / <ΔA>
        {
            string myTempKey="";
            foreach (var word in words.Keys)// = 0; k < ns.NKs.Count - 1; ++k)
            {

                double A = avgA(word);  // <ΔA>
                double A2 = squareAvgA(word);  //<ΔA^2>
                words[word].dispersionEstimation = Math.Sqrt(A2 - A * A) / A; // calculate DE for each term in text
                myTempKey = word; //debug
            }
            return words[myTempKey].dispersionEstimation;
        }

            /*
             *         public double mainFormula()  //Math.Sqrt(<ΔA^2> - <ΔA>^2) / <ΔA>
            {
            foreach (var word in words.Keys)// = 0; k < ns.NKs.Count - 1; ++k)
            {

                double A = avgA();  // <ΔA>
                double A2 = squareAvgA();  //<ΔA^2>
                return Math.Sqrt(A2 - A * A) / A;
            }

            */

        public double analyzeDE(List<string> unknownCategoryWords)
        {
            preinit();
            init(unknownCategoryWords);
            return mainFormula(); //DE of a random word
        }
        
    }
}
