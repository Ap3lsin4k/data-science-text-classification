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


namespace Text_analyzer.model.repository
{
    //wrapper to WordFreq
    class TextJsonRepository
    {
        public Dictionary<string, WordFreq> library;  //<category, and parametrs for it>

        //todo: make local
        public string json;

        public TextJsonRepository()
        {
            library = new Dictionary<string, WordFreq>();
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

                Dictionary<string, WordFreq> deserialize = 
                    JsonConvert.DeserializeObject<Dictionary<string, WordFreq>>(this.json);
                if (deserialize != null)
                {
                    this.library = deserialize;
                    //MessageBox.Show("Succesfully loaded"); TODO decoment
                }
                else  // if json file is invalid
                {
                    this.library = new Dictionary<string, WordFreq>();
                    MessageBox.Show("Deserialize was failed. I will create new object. Don't forget to press Save!");
                }
                return true;
            }
            catch(Exception e)
            {
                this.library = new Dictionary<string, WordFreq>();
                MessageBox.Show("Could not find analysis.json file. I will create object. Don't forget to press Save!");
                return false;
            }
        }

        public string[] getCategories()
        {
            return library.Keys.ToArray();
        }


        public void addCategory(string shelf, List<string> texts)
        {
            library[shelf] = new WordFreq(texts);  // TODO test: casting to List can take much time
        }

        // words may be repeated
        public List<string> getAllWordsFromShelf(string shelf)
        {
            return library[shelf].allWords;
        }

        public void uniquifyWordsIn(string shelf)
        {
            foreach (string word in getAllWordsFromShelf(shelf))
            {
                if (library[shelf].n.ContainsKey(word))
                    ++library[shelf].n[word];
                else
                    library[shelf].n[word] = 1;
                
            }
        }

        public int howManyTimesWordAppear(string shelf, string word)
        {
            return library[shelf].n[word];
        }

        public Dictionary<string, int>.KeyCollection getUniqueWords(string shelf)
        {
            return library[shelf].n.Keys;
        }

        public IOrderedEnumerable<KeyValuePair<string, int>> getUniqueWordsOrderByDescending(string shelf)
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
            return library[shelf].TF[word];// todo check whether tf exists
        }
        
        public Dictionary<string, WordFreq> getLibrary()
        {
            return library; // all shelfs in library.
        }

        // number words in all texts for each category
        public int getNumberOfShelfsInLibrary() 
        {
            return library.Count;
        }

        public double calculateIdf(string shelf, string word, int numOfDocsWhereWordAppears)
        {
            return library[shelf].calcIdf(word, getNumberOfShelfsInLibrary(), numOfDocsWhereWordAppears);
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


    }
}
