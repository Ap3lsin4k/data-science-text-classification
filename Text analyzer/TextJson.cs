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


namespace Text_analyzer
{
    class TextJson
    {
        public Dictionary<string, WordFreq> texts;  //category, and parametrs for it
        public string json;

        public TextJson()
        {
            texts = new Dictionary<string, WordFreq>();
        }
        /*
        public TextJson(Dictionary<string, WordFreq> texts)
        {
            this.texts = texts;
            this.json = JsonConvert.SerializeObject(this.texts);
            //{
            //  "Name": "Apple",
            //  "Expiry": "2008-12-28T00:00:00",
            //  "Price": 3.99,
            //  "Sizes": [
            //    "Small",
            //    "Medium",
            //    "Large"
            //  ]
            //}

            //WordFreq deserializedProduct = JsonConvert.DeserializeObject<WordFreq>(json);
*/
        public void save()
        {
            //save json to file
            this.json = JsonConvert.SerializeObject(this.texts);

            FileInfo f = new FileInfo("analysis.json");
            StreamWriter w = f.CreateText();
            w.Write(this.json);
            /*w.WriteLine("Chapter 6");
            w.WriteLine("Of C# Module");
            w.WriteLine("Thanks for your time");
            
            */w.Close();
        }
        public void show()
        {
            this.json = JsonConvert.SerializeObject(this.texts);
            MessageBox.Show(json);
        }
        public void load()
        {
            try
            {
                //load from file
                this.json = File.ReadAllText("analysis.json");
                //this.texts = JsonConvert.DeserializeObject<Dictionary<string, WordFreq>>(this.json);

                Dictionary<string, WordFreq> deserialize = 
                    JsonConvert.DeserializeObject<Dictionary<string, WordFreq>>(this.json);
                if (deserialize != null)
                {
                    this.texts = deserialize;
                    MessageBox.Show("Succesfully loaded");
                }
                else
                {
                    this.texts = new Dictionary<string, WordFreq>();
                    MessageBox.Show("Deserialize was failed. I will create new clear file");
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show("Could not find analysis.json file. I will create new");
            }
        }
    }
}
