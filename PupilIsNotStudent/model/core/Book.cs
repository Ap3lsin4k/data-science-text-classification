using System;
using System.Collections.Generic;

namespace PupilIsNotStudent.model.core
{
    // Entity
    internal class Book // an news, an text
    {

        public Dictionary<string, uint> n;  // <word, frequency of appearing>
        public Dictionary<string, double> TF;  // <word, Term frequency in %>
        public Dictionary<string, double> IDF;  // <word, normalized Inverse document frequency>
        public Dictionary<string, double> TFIDF;  // <word, Term frequency – Inverse document frequency>
        DE DE;

        // including disordered(aka shuffled, aka repeated) words
        private UInt64 numOfAllWords;

        // constructor to deserialize json
        public Book()
        {
            n = new Dictionary<string, uint>();
            TF = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();
            DE = new DE();
            numOfAllWords = 0;
        }

        // constructor for common use
        public Book(in string[] words) : this() 
        {
            memorizeWords(words);
        }

        // save unique words. Don't forget to update numOfAllWords (e.g. numOfAllWords += disorderedWords.Length)
        public void memorizeWords(in string[] disorderedWords)
        {
            numOfAllWords += Convert.ToUInt64(disorderedWords.Length);
            foreach (string word in disorderedWords)
            {
                if (n.ContainsKey(word))
                    ++n[word];
                else
                    n[word] = 1;

            }
        }

        // for the first time
        public void updateTF()
        {
            foreach (var word in n)
            {
                TF[word.Key] = 100.0 * word.Value / numOfAllWords; // to find TF in percentages
                // implicit cast (int) to (double), to make normal division
            }

        }

        // relearning
        public void updateTF(in HashSet<string> words)
        {
            foreach (string word in words)
            {
                TF[word] = 100.0 * n[word] / numOfAllWords; // to find TF in percentages
            }
            
        }

        public double calcTf(string key)
        {
            TF[key] = 100.0 * n[key] / numOfAllWords; // to find TF in percentages
            // implicit cast (int) to (double), to make normal division
            return TF[key];
        }

        
        public double calcIdf(string key, int B, int t) // t is always <= D
        {
            /*
            base 10 logarithm of (
                total number of documents(aka shelves aka books) in the collection (D)
                divided by
                number of books where term appears (t)
            )
            */
            IDF[key] = Math.Log10((float)B / (float)t); 
            return IDF[key];
        }

        void updateIDF(in HashSet<string> words)
        {
            foreach (string word in words)
            {
    //            IDF[word] = Math.Log10((float)D / (float)t);
            }
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


        // Relearning
        public void relearnTf(in string[] disorderedWords)
        {
//            memorizeWords(in disorderedWords);
            numOfAllWords += Convert.ToUInt64(disorderedWords.Length);
            foreach (string word in disorderedWords)
            {
                if (n.ContainsKey(word)){
                    ++n[word];
                }
                else {
                    n[word] = 1;
                }

            }
            
            HashSet<string> uniqueWords = new HashSet<string>(disorderedWords);
            updateTF(uniqueWords);

        }
    }
}


/*
 * Max number of categories = 255
 * Max number of occurrences of a single word 4 billion (4 * 10**9)
 * Max number of occurrences: 1.8 * 10**19
 * 
 * */
