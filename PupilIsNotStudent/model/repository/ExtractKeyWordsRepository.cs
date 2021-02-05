using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// work with files
using System.IO;
// json
using Newtonsoft.Json;
using PupilIsNotStudent.model.core;


namespace PupilIsNotStudent.model.repository
{
    //wrapper to WordFreq
    class ExtractKeyWordsRepository
    {
        public Dictionary<string, Book> Library;  //<category, and parametrs for it>

        //todo: make local
        public string Json;

        public ExtractKeyWordsRepository()
        {
            Library = new Dictionary<string, Book>();
        }

        // =====JSON=====
        public void Save()
        {
            //save json to file
            this.Json = JsonConvert.SerializeObject(this.Library);

            FileInfo f = new FileInfo("analysis.json");
            StreamWriter w = f.CreateText();
            w.Write(this.Json);
            w.Close();
        }

        public void Show()
        {
            this.Json = JsonConvert.SerializeObject(this.Library);
            MessageBox.Show(Json);
        }

        public bool DeserializeFromFile()
        {
            try
            {
                //load from file
                this.Json = File.ReadAllText("analysis.json");

                Dictionary<string, Book> deserialize = 
                    JsonConvert.DeserializeObject<Dictionary<string, Book>>(this.Json);
                if (deserialize != null)
                {
                    this.Library = deserialize;
                }
                else  // if json file is invalid
                {
                    this.Library = new Dictionary<string, Book>();
                    MessageBox.Show("Deserialize was failed. I will create new object. Don't forget to press Save!");
                }
                return true;
            }
            catch(Exception)
            {
                this.Library = new Dictionary<string, Book>();
                MessageBox.Show("Could not find file: \"analysis.json\". Creating a new object. Don't forget to press Save!");
                return false;
            }
        }


        // Extract Key Words
        public Dictionary<string, Book>.KeyCollection GetCategories()
        {
            return Library.Keys;
        }


        public void AppendCategory(string shelf, in string[] texts)
        {
            Library[shelf] = new Book(texts);
        }


        public bool WhetherCategoryExist(string shelf)
        {
            return Library.ContainsKey(shelf);
        }


        // number words in all texts for each category
        public byte GetNumberOfShelvesInLibrary() 
        {
            return (byte) Library.Count;
        }




        // ======Term Frequency======
        public void ComputeTermFrequencyAltogether(string shelf)
        {
            Library[shelf].ComputeTermFrequencyAltogether();
        }



        // ======Inverse Doc Frequency======
        private void IDFForOtherCategories(string shelf, string word)
        {
            byte numOfBooksWhereWordAppears = 1;
            foreach (KeyValuePair<string, Book> book in Library)
            {
                if (book.Key == shelf) continue;

                if (book.Value.N.ContainsKey(word))
                {
                    ++numOfBooksWhereWordAppears; // if at least a word is in other category we count it and go to another text
                }

            }

            Library[shelf].ComputeIDF(word, GetNumberOfShelvesInLibrary(), numOfBooksWhereWordAppears);
        }


        // initialize each single word in a book
        private void IDFForEachWordInBook(string shelf)
        {
            foreach (var word in Library[shelf].N.Keys)
            {
                IDFForOtherCategories(shelf, word);

            }
        }
        // update only new words
        private void IDFForNewWordsInBook(string shelf, HashSet<string> specificWords)
        {
            foreach (var word in specificWords)
            {
                IDFForOtherCategories(shelf, word);

            }
        }


        public void IDFForEachBook()
        {
            foreach (string shelf in Library.Keys)
            {
                IDFForEachWordInBook(shelf);

            }
        }




        // ======Term Frequency - Inverse Doc Frequency======
        public void CalculateTermFrequencyInverseDocumentFrequency(string shelf)
        {
            Library[shelf].ComputeTFIDFAltogether();
        }

        public IOrderedEnumerable<KeyValuePair<string, double>> GetTermFrequencyInverseDocumentFrequencyOrderByDescending(string shelf)
        {
            return Library[shelf].TFIDF.OrderByDescending(key => key.Value);
        }


        public bool TermFrequencyExist(string shelf)
        {
            return Library[shelf].TermFrequency.Count != 0;
        }

        public bool InverseDocumentFrequencyExist(string shelf)
        {
            return Library[shelf].IDF.Count != 0;
        }

        // ======Relearner======
        public void Relearn(string shelf, in string[] shuffledWords)
        {
            var uniqueWords = new HashSet<string>(shuffledWords);

            Library[shelf].MemorizeWords(shuffledWords);
            
            Library[shelf].UpdateTermFrequencyForNewWords(uniqueWords);
            IDFForNewWordsInBook(shelf, uniqueWords);
            Library[shelf].UpdateTermFrequencyIDFForSpecificWords(uniqueWords);
            
        }
    }
}
