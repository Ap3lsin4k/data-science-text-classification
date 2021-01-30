using System;
using System.Collections.Generic;

namespace PupilIsNotStudent.model.core
{
    // Entity
    internal class Book // an news, an text
    {
        // AVG length is 4000 items
        public Dictionary<string, uint> N;  // <word, frequency of appearing>
        public Dictionary<string, double> TermFrequency;  // <word, Term frequency in %>
        public Dictionary<string, double> IDF;  // <word, normalized Inverse document frequency>
        public Dictionary<string, double> TFIDF;  // <word, Term frequency – Inverse document frequency>

        // including disordered(aka shuffled, aka repeated) words
        private UInt64 _numOfAllWords;

        // constructor to deserialize json
        public Book()
        {
            N = new Dictionary<string, uint>();
            TermFrequency = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();
            _numOfAllWords = 0;
        }

        // constructor for common use
        public Book(in string[] words) : this() 
        {
            MemorizeWords(words);
        }

        // save unique words. Don't forget to update numOfAllWords (e.g. numOfAllWords += disorderedWords.Length)
        public void MemorizeWords(in string[] disorderedWords)
        {
            _numOfAllWords += Convert.ToUInt64(disorderedWords.Length); 
            foreach (string word in disorderedWords)
            {
                if (N.ContainsKey(word))
                    ++N[word];
                else
                    N[word] = 1;

            }
        }

        // ======Term Frequency======

        // for the first time
        public void ComputeTermFrequencyAltogether()
        {
            foreach (var word in N)
            {
                TermFrequency[word.Key] = 100.0 * word.Value / _numOfAllWords; // to find TermFrequency in percentages
                // implicit cast (int) to (double), to make normal division
            }

        }

        // relearning
        public void UpdateTermFrequencyForNewWords(in HashSet<string> specificWords)
        {
            foreach (string word in specificWords)
            {
                TermFrequency[word] = 100.0 * N[word] / _numOfAllWords; // to find TermFrequency in percentages
            }
            
        }



        // ======Inverse Doc Frequency======

        // compute for the first time or update
        public double ComputeIDF(string word, byte d, byte t) // t is always <= D
        {
            /*
            logarithm of (
                total number of documents(aka shelves aka books) in the collection(aka library) (D)
                divided by
                number of books where term appears (t)
            )
            */
            IDF[word] = Math.Log10((float)d / (float)t); 
            return IDF[word];
        }


        // ======TermFrequency*IDF======

        // to create TermFrequency*IDF for the first time
        public void ComputeTFIDFAltogether()
        {
            foreach (string word in N.Keys)
                TFIDF[word] = TermFrequency[word] * IDF[word];  // aka TermFrequency-IDF = TermFrequency*IDF
        }

        // to relearn existing TermFrequency*IDF. Updates only new words.
        public void UpdateTermFrequencyIDFForSpecificWords(in HashSet<string> specificWords)
        {
            foreach (string word in specificWords)
                TFIDF[word] = TermFrequency[word] * IDF[word];  // aka TermFrequency-IDF = TermFrequency*IDF
        }






        // Relearning
        public void RelearnTermFrequency(in string[] disorderedWords)
        {
            MemorizeWords(in disorderedWords);
            
        }
    }
}


/*
 * Max number of categories = 255
 * Max number of occurrences of a single word 4 billion (4 * 10**9)
 * Max number of occurrences: 1.8 * 10**19
 * 
 * */
