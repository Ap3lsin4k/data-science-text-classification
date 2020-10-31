using System;
using System.Collections.Generic;

namespace PupilIsNotStudent.model.core
{
    // Entity
    internal class Book // an news, an text
    {
        // AVG length is 4000 items
        public Dictionary<string, uint> n;  // <word, frequency of appearing>
        public Dictionary<string, double> TermFrequency;  // <word, Term frequency in %>
        public Dictionary<string, double> IDF;  // <word, normalized Inverse document frequency>
        public Dictionary<string, double> TFIDF;  // <word, Term frequency – Inverse document frequency>

        // including disordered(aka shuffled, aka repeated) words
        private UInt64 numOfAllWords;

        // constructor to deserialize json
        public Book()
        {
            n = new Dictionary<string, uint>();
            TermFrequency = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();
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

        // ======Term Frequency======

        // for the first time
        public void computeTermFrequencyAltogether()
        {
            foreach (var word in n)
            {
                TermFrequency[word.Key] = 100.0 * word.Value / numOfAllWords; // to find TermFrequency in percentages
                // implicit cast (int) to (double), to make normal division
            }

        }

        // relearning
        public void updateTermFrequencyForNewWords(in HashSet<string> specificWords)
        {
            foreach (string word in specificWords)
            {
                TermFrequency[word] = 100.0 * n[word] / numOfAllWords; // to find TermFrequency in percentages
            }
            
        }



        // ======Inverse Doc Frequency======

        // compute for the first time or update
        public double computeIDF(string word, byte D, byte t) // t is always <= D
        {
            /*
            logarithm of (
                total number of documents(aka shelves aka books) in the collection(aka library) (D)
                divided by
                number of books where term appears (t)
            )
            */
            IDF[word] = Math.Log10((float)D / (float)t); 
            return IDF[word];
        }


        // ======TermFrequency*IDF======

        // to create TermFrequency*IDF for the first time
        public void computeTermFrequencyIDFAltogether()
        {
            foreach (string word in n.Keys)
                TFIDF[word] = TermFrequency[word] * IDF[word];  // aka TermFrequency-IDF = TermFrequency*IDF
        }

        // to relearn existing TermFrequency*IDF. Updates only new words.
        public void updateTermFrequencyIDFForSpecificWords(in HashSet<string> specificWords)
        {
            foreach (string word in specificWords)
                TFIDF[word] = TermFrequency[word] * IDF[word];  // aka TermFrequency-IDF = TermFrequency*IDF
        }






        // Relearning
        public void relearnTermFrequency(in string[] disorderedWords)
        {
            memorizeWords(in disorderedWords);
            
        }
    }
}


/*
 * Max number of categories = 255
 * Max number of occurrences of a single word 4 billion (4 * 10**9)
 * Max number of occurrences: 1.8 * 10**19
 * 
 * */
