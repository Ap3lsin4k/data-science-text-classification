using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class WordFreq // an news, an text
    {

        public Dictionary<string, int> n;  // частота входжень обраного слова
        public Dictionary<string, double> TF;
        public Dictionary<string, double> IDF;
        public Dictionary<string, double> TFIDF;

        public bool flagTf, flagIdf;

        public List<string> allWords;

        public WordFreq() // constructor to deserialize json
        {
            n = new Dictionary<string, int>();
            TF = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();  // to each word his TFIDF
            allWords = new List<string>();
        }

        public WordFreq(List<string> words)
        {
            n = new Dictionary<string, int>();
            TF = new Dictionary<string, double>();
            IDF = new Dictionary<string, double>();
            TFIDF = new Dictionary<string, double>();  // to each word his TFIDF
            allWords = new List<string>();
            if (words[words.Count - 1] == "")
            {
                for (int i = 0; i < words.Count - 1; ++i)
                {
                    allWords.Add(words[i]);
                }
            }
            else
                allWords = words;
            
            
        }

        public double getTf(string key)
        {
            flagTf = true;
            TF[key] = Math.Round(100.0 *  // percent
                        n[key] / allWords.Count, // to find TF
                    2);  // numbers after coma
            return TF[key];
        }

        public double getIdf(string key, int D, int t) // inverse document frequency
        {
            flagIdf = true;
            IDF[key] = Math.Log10((float)D / (float)t);
            return IDF[key];
        }

        public void getTfIdf() // inverse document frequency
        {
            
            foreach (string word in n.Keys)
            {
                TFIDF[word] = TF[word] * IDF[word];
            }
          
        }
    }
}
/*
 * {
  "Спорт" : {
    "allWords":[
      "донецький",
      "шахтар",
      "не",
      "потрапить",
      "у",
      "в",
      "на"
      ],
    "n":{
"донецький":3,
      "шахтар":70,
      "не":60,
      "потрапить":50,
      "у":40,
      "в":30,
      "на":20
      
    },
    "TF":{},
    "IDF":{},
    "TFIDF":{}
    },
  "Здоров'я" : {
    "allWords":[
      "донецький",
      "шахтар",
      "не",
      "потрапить",
      "у",
      "в",
      "на"
      ],
    "n":{
      "донецький":3,
      "шахтар":70,
      "не":60,
      "потрапить":50,
      "у":40,
      "в":30,
      "на":20,
    },
    "TF":{},
    "IDF":{},
    "TFIDF":{}
    },
  "Наука" : {
    "allWords":[
      "донецький",
      "шахтар",
      "не",
      "потрапить",
      "у",
      "в",
      "на"
      ],
    "n":{
      "донецький":3,
      "шахтар":70,
      "не":60,
      "потрапить":50,
      "у":40,
      "в":30,
      "на":20,
      //n1
    },
    "TF":{},
    "IDF":{},
    "TFIDF":{}
    }
}
*/