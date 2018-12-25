using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//json
using Newtonsoft.Json;
namespace Text_analyzer
{
    class TextJson
    {
        public Dictionary<string, WordFreq> texts;
        public string json;

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
        }

        public void save()
        {
            this.json = JsonConvert.SerializeObject(this.texts);
            //save json to file
        }
        public void show()
        {
            MessageBox.Show(json);
        }
        public void load()
        {
            //load from file
            this.texts = JsonConvert.DeserializeObject<Dictionary<string, WordFreq>>(json);
        }
    }
}
