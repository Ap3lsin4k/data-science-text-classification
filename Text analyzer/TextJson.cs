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
        public Dictionary<string, WordFreq> texts;  //<category, and parametrs for it>
        public string json;

        public TextJson()
        {
            texts = new Dictionary<string, WordFreq>();
        }

        public void save()
        {
            //save json to file
            this.json = JsonConvert.SerializeObject(this.texts);

            FileInfo f = new FileInfo("analysis.json");
            StreamWriter w = f.CreateText();
            w.Write(this.json);
            w.Close();
        }

        public void show()
        {
            this.json = JsonConvert.SerializeObject(this.texts);
            MessageBox.Show(json);
        }

        public bool load()
        {
            try
            {
                //load from file
                this.json = File.ReadAllText("analysis.json");

                Dictionary<string, WordFreq> deserialize = 
                    JsonConvert.DeserializeObject<Dictionary<string, WordFreq>>(this.json);
                if (deserialize != null)
                {
                    this.texts = deserialize;
                    //MessageBox.Show("Succesfully loaded"); TODO decoment
                }
                else  // if json file is invalid
                {
                    this.texts = new Dictionary<string, WordFreq>();
                    MessageBox.Show("Deserialize was failed. I will create new object. Don't forget to press Save!");
                }
                return true;
            }
            catch(Exception e)
            {
                this.texts = new Dictionary<string, WordFreq>();
                MessageBox.Show("Could not find analysis.json file. I will create object. Don't forget to press Save!");
                return false;
            }
        }
    }
}
