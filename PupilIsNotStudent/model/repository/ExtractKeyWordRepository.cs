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
    class ExtractKeyWordRepository
    {
        public Dictionary<string, Book> library;  //<category, and parametrs for it>

        //todo: make local
        public string json;

        public ExtractKeyWordRepository()
        {
            library = new Dictionary<string, Book>();
        }

        public void save()
        {
            //save json to file
            this.json = JsonConvert.SerializeObject(this.library);

            FileInfo f = new FileInfo("analysis.json");
            StreamWriter w = f.CreateText();
            w.Write(this.json);
            w.Close();
        }

        public void show()
        {
            this.json = JsonConvert.SerializeObject(this.library);
            MessageBox.Show(json);
        }

        public bool deserializeFromFile()
        {
            try
            {
                //load from file
                this.json = File.ReadAllText("analysis.json");

                Dictionary<string, Book> deserialize = 
                    JsonConvert.DeserializeObject<Dictionary<string, Book>>(this.json);
                if (deserialize != null)
                {
                    this.library = deserialize;
                    //MessageBox.Show("Succesfully loaded"); TODO decoment
                }
                else  // if json file is invalid
                {
                    this.library = new Dictionary<string, Book>();
                    MessageBox.Show("Deserialize was failed. I will create new object. Don't forget to press Save!");
                }
                return true;
            }
            catch(Exception e)
            {
                this.library = new Dictionary<string, Book>();
                MessageBox.Show("Could not find analysis.json file. I will create object. Don't forget to press Save!");
                return false;
            }
        }

        public string[] getCategories()
        {
            return library.Keys.ToArray();
        }


        public void addCategory(string shelf, in string[] texts)
        {
            library[shelf] = new Book(texts);
        }

        public uint howManyTimesWordAppear(string shelf, string word)
        {
            return library[shelf].n[word];
        }

        public Dictionary<string, uint>.KeyCollection getUniqueWords(string shelf)
        {
            return library[shelf].n.Keys;
        }

        public IOrderedEnumerable<KeyValuePair<string, uint>> getUniqueWordsOrderByDescending(string shelf)
        {
            return library[shelf].n.OrderByDescending(key => key.Value);
        }

        public double calculateTf(string shelf, string word)
        {
            return library[shelf].calcTf(word);
        }

        public bool whetherCategoryExist(string shelf)
        {
            return library.ContainsKey(shelf);
        }

        public double getTf(string shelf, string word)
        {
            return library[shelf].TF[word];
        }
        
        public Dictionary<string, Book> getLibrary()
        {
            return library; // all shelfs in library.
        }

        // number words in all texts for each category
        public int getNumberOfShelvesInLibrary() 
        {
            return library.Count;
        }



        // ======IDF======
        public double IDFForOtherCategories(string shelf, string word)
        {
            byte numOfBooksWhereWordAppears = 1;
            foreach (KeyValuePair<string, Book> book in library)
            {
                if (book.Key == shelf) continue;

                if (book.Value.n.ContainsKey(word))
                {
                    ++numOfBooksWhereWordAppears; // if at least a word is in other category we count it and go to another text
                    //break; // don't write break.
                }

            }

            return library[shelf].calcIdf(shelf, getNumberOfShelvesInLibrary(), numOfBooksWhereWordAppears);
        }








        public void calculateTfIdf(string shelf)
        {
            library[shelf].calcTfIdf();
        }

        public IOrderedEnumerable<KeyValuePair<string, double>> getTfIdfOrderByDescending(string shelf)
        {
            return library[shelf].TFIDF.OrderByDescending(key => key.Value);
        }

        public bool tfExist(string shelf)
        {
            return library[shelf].TF.Count != 0;
        }

        public bool idfExist(string shelf)
        {
            return library[shelf].IDF.Count != 0;
        }

        // Relearner
        void relearn(string shelf, string[] shuffledWords)
        {
            library[shelf].memorizeWords(shuffledWords);
         //   library[shelf].calcTf();
        }
    }
}
