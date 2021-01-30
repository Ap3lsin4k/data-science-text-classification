using System;
using System.Collections.Generic;
using System.Linq;

namespace PupilIsNotStudent.model.core
{
    internal class DisperseEstimation
    {
        public class IndexInText
        {
            public List<int> NKs = new List<int>();  //an array with function pushback(add) list of indexes where the term A is 
            public double AverageAs; // AVG(NKs[1]-NKs[0], NKs[2]-NKs[1],..., NKs[K]-NKs[K-1])  // average terms
            public double SqAvgAs;  // AVG((NKs[1]-NKs[0])^2, (NKs[2]-NKs[1])^2, ..., (NKs[K]-NKs[K-1])^2)  // square average distance between occurance of terms
            public double DispersionEstimation;
        }

        public Dictionary<string, IndexInText> Words;
        private int _numberOfAllWords = -1;

        //todo unique words | what that means? todos going to be deleted or moved into backlog


        public DisperseEstimation()
        {
            this.Words = new Dictionary<string, IndexInText>();
        }

        public string AnalyzeDe(in string[] unknownCategoryWords)
        {
            Preinit();
            Init(unknownCategoryWords);
            return MainFormula(); //DE of a random word
        }

        private void Preinit()
        {
            // Clear dictionary to add new words
            this.Words.Clear();
        }

        public void Init(in string[] wordsToAnalyse)
        {
            int n = 1;
            foreach (string aWord in wordsToAnalyse)
            {
                if (!Words.ContainsKey(aWord))
                {            // create new word
                    Words[aWord] = new IndexInText();
                }
                // add the position of the next occurrence of the word
                Words[aWord].NKs.Add(n);
                ++n;// move text pivot to the next word
            }
            _numberOfAllWords= wordsToAnalyse.Length; // number of all = n-1; (?)
        }


        int DeltaA(List<int> a, int k)
        {
            /*
             k: 0  1   2    3
             n: 1  3  113  127
              */
            // distance between occurrences of term
            return a[k + 1] - a[k];  // m-n; where m, n are neighbor position of the "A" word
       }

        //A is term like "word"

        private double AvgA(string a)  // <ΔA> = AVG(ΔA, ΔA, ΔA...)
        {
            int sum = 0, k, length= Words[a].NKs.Count;

            for (k = 0; k < length - 1; ++k)
            {
                sum += DeltaA(Words[a].NKs, k);  // m-n
            }
            //k == words[A].NKs.Count - 1 // last index = length-1 due to indexation that begins with 0

            /*
            0123456
            ..A..A.
            first delta equal distance between  = 5-2 = 3


            in case text is round
            5671234
            .A...A.
            second delta is length - last occurrence, + first occurrence = (7-6) + (3) = 1 + 3 = 4
            Note "+1" because of zero-indexing
            */
            sum += (_numberOfAllWords - Words[a].NKs[k]) + Words[a].NKs[0];
            //...A....A1...A2.....A3...
            /*
            //last delta equal (length()-A3)+A
             */

            //save average A for each term
            //todo check if length is not zero
            Words[a].AverageAs = (double)sum / length; // AVG = sum divided by number of variables(n)
           
           
            return Words[a].AverageAs;
        }

        //todo optimize don't count delta two times

        private double SquareAvgA(string a) //<ΔA^2> = AVG(ΔA^2, ΔA^2, ΔA^2...)
        {
            int sum = 0, k;
            int length = Words[a].NKs.Count, deltaMn;

            for (k = 0; k < length - 1; ++k)
            {
                deltaMn = DeltaA(Words[a].NKs, k);
                sum += deltaMn * deltaMn;  // (m-n) squared
            }
            deltaMn = (_numberOfAllWords - Words[a].NKs[k]) + (Words[a].NKs[0]);
            sum += deltaMn * deltaMn;

            /*
             obsolete
            //save average A for each term
            if (words[A].NKs.Count - 1 != 0)
                words[A].sqAvgAs = (double)sum / (words[A].NKs.Count - 1); // AVG = sum divided by number of variables(n)
            else
                words[A].sqAvgAs = words.Count; // TODO fix for single words in text
                */
            Words[a].SqAvgAs = (double)sum / length;
            return Words[a].SqAvgAs;
        }

        public string MainFormula()  //Math.Sqrt(<ΔA^2> - <ΔA>^2) / <ΔA>
        {
            //math.sqrt((A[0] * A[0] + A[1] * A[1]) / 2 - avg(A) ** 2)/avg(A)
            foreach (var word in Words.Keys)// = 0; k < ns.NKs.Count - 1; ++k)
            {
                double a = AvgA(word);  // <ΔA>
                double a2 = SquareAvgA(word);  //<ΔA^2>
                Words[word].DispersionEstimation = Math.Sqrt(a2 - a * a) / a; // calculate DE for each term in text
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
            foreach (var dict in Words.OrderByDescending(key => key.Value.DispersionEstimation))
            {
                outDebug += 
                    dict.Key 
                    +":"
                    + Math.Round(dict.Value.DispersionEstimation, 1) 
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
    }
}
