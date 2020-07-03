using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PupilIsNotStudent
{
    class DE
    {
        //TODO static
        public class NKavgA
        {
            public List<int> NKs = new List<int>();  //an array with function pushback(add) list of indexes where the term A is 
            public double averageAs; // AVG(NKs[1]-NKs[0], NKs[2]-NKs[1],..., NKs[K]-NKs[K-1])  // average terms
            public double sqAvgAs;  // AVG((NKs[1]-NKs[0])^2, (NKs[2]-NKs[1])^2, ..., (NKs[K]-NKs[K-1])^2)  // square average distance between occurance of terms
            public double dispersionEstimation;
        }

        public Dictionary<string, NKavgA> words;
        public int numberOfAllWords = -1;

        //todo unreapeated words


        public DE()
        {
            this.words = new Dictionary<string, NKavgA>();
        }
        public void preinit()
        {
            // Clear dictionary to add new words
            this.words.Clear();
        }

        public void init(in string[] wordsToAnalyse)
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
            numberOfAllWords= wordsToAnalyse.Length; // number of all = n-1; (?)
        }


        int deltaA(List<int> A, int k)
        {
            /*
             k: 0  1   2    3
             n: 1  3  113  127
              */
            // distance between ocurrance of term
            return A[k + 1] - A[k];  // m-n; where m, n are neighbor position of the "A" word
       }

        //A is term like "word"
        private double avgA(string A)  // <ΔA> = AVG(ΔA, ΔA, ΔA...)
        {
            int sum = 0, k, length= words[A].NKs.Count;

            for (k = 0; k < length - 1; ++k)
            {
                sum += deltaA(words[A].NKs, k);  // m-n
            }
            //k == words[A].NKs.Count - 1 // last index = length-1 due to indexation that begins with 0

            /*
            0123456
            ..A..A.
            first delta equal distance between  = 5-2 = 3


            in case text is round
            5671234
            .A...A.
            second delta is length - last occurance, + first occurence = (7-6) + (3) = 1 + 3 = 4
            Note "+1" because of zero-indexing
            */
            sum += (numberOfAllWords - words[A].NKs[k]) + words[A].NKs[0];
            //...A....A1...A2.....A3...
            /*
            //last delta equal (length()-A3)+A
             */

            //save average A for each term
            //todo check if length is not zero
            words[A].averageAs = (double)sum / length; // AVG = sum divided by number of variables(n)
           
           
            return words[A].averageAs;
        }
        //todo optimise we count delta two times
        private double squareAvgA(string A) //<ΔA^2> = AVG(ΔA^2, ΔA^2, ΔA^2...)
        {
            int sum = 0, k;
            int length = words[A].NKs.Count, deltaMN;

            for (k = 0; k < length - 1; ++k)
            {
                deltaMN = deltaA(words[A].NKs, k);
                sum += deltaMN * deltaMN;  // (m-n) squared
            }
            deltaMN = (numberOfAllWords - words[A].NKs[k]) + (words[A].NKs[0]);
            sum += deltaMN * deltaMN;

            /*
             obsolete
            //save average A for each term
            if (words[A].NKs.Count - 1 != 0)
                words[A].sqAvgAs = (double)sum / (words[A].NKs.Count - 1); // AVG = sum divided by number of variables(n)
            else
                words[A].sqAvgAs = words.Count; // TODO fix for single words in text
                */
            words[A].sqAvgAs = (double)sum / length;
            return words[A].sqAvgAs;
        }

        public string mainFormula()  //Math.Sqrt(<ΔA^2> - <ΔA>^2) / <ΔA>
        {
       
            string myTempKey="";
            foreach (var word in words.Keys)// = 0; k < ns.NKs.Count - 1; ++k)
            {
                double A = avgA(word);  // <ΔA>
                double A2 = squareAvgA(word);  //<ΔA^2>
                words[word].dispersionEstimation = Math.Sqrt(A2 - A * A) / A; // calculate DE for each term in text
                myTempKey = word; //debug
            }
            //TODO the last key is ""

            string outDebug = "";

            /*
            
            {
            "думи": {
                "DE" : 158,
                "A" : 1.11,
                "A2" : 32814.13
                },
            "мої" : {  "DE" : 137, ...}
            }

             * */
            foreach (var dict in words.OrderByDescending(key => key.Value.dispersionEstimation))
            {
                outDebug += 
                    dict.Key 
                    +":"
                    + Math.Round(dict.Value.dispersionEstimation, 1) 
                    + "\n";
            }



            return outDebug;
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

        public string analyzeDE(in string[] unknownCategoryWords)
        {
            preinit();
            init(unknownCategoryWords);
            return mainFormula(); //DE of a random word
        }
        
    }
}
