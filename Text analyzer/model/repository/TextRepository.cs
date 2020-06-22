using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Text_analyzer.model.repository
{
    class TextRepository
    {
        const int keyWordsLimit = 155;
        
        DE myDe = new DE();


        //==========TEXT PARSER==========
        public string getRawText(string notClearedText)
        {
            string news = Regex.Replace(notClearedText, @"\s+", " ");
            string peeledText = "";


            foreach (char symbol in news)
            {
                if (isCyrillic(symbol))
                    peeledText += Char.ToLower(symbol);
                else
                    peeledText += " ";
            }

            // To get rid of empty string{..., "...", "", "..", ...} at the end of the array.

   //         peeledText = Regex.Replace(peeledText, @"\s+", " "); // To delete redundant space
     //       if (peeledText[peeledText.Length - 1] == ' ')
       //         peeledText = peeledText.Substring(0, peeledText.Length - 1);

            return peeledText;
        }



        public string[] getSplitStrings(string notClearedText)
        {
            //return "човен  ".Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            return getRawText(notClearedText).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }


        public List<string> getRawTextSplit(string notClearedText)
        {
            return getRawText(notClearedText).Split().ToList<string>();
        }

        // It  is never called
        public List<string> getRawTextSplit(System.Windows.Forms.TextBox tbWithText)
        {
            return getRawText(tbWithText.Text.ToString()).Split().ToList<string>();
        }



        private bool isCyrillic(int letterCode)
        {
            switch (letterCode)
            {
                case 1028: // Є
                case 1108: // є
                case 1030: // І
                case 1110: // і
                case 1031: // Ї
                case 1111: // ї
                case 1168: // Ґ
                case 1169: // ґ
                case 32:  // " "
                case 39:  // '
                          //case 45:  // -
                    return true;
                default:  // TODO add English support
                    return
                        1040 <= letterCode && letterCode <= 1103 &&  // Cyrillic
                        letterCode != 1066 &&  // Ъ
                        letterCode != 1067 &&  // Ы
                        letterCode != 1098  // ъ
                        ;
            }

        }

        // ==========TEXT ANALYZER==========
        public Dictionary<string, int> associateOccurrencesWithTerms(ref string[] words)
        {
            Dictionary<string, int> n = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (n.ContainsKey(word)) ++n[word];
                else n[word] = 1;

            }
            return n;
        }

        public string computeDe(List<string> splitText)
        {
            return myDe.analyzeDE(splitText);
        }

        public utils.IndicatorsOfAffiliationForText computeAffiliationOfTextToCategory(Dictionary<string, int>.KeyCollection unrepeatedWords, Dictionary<string, double> tfIdf)
        {
            utils.IndicatorsOfAffiliationForText scores = new utils.IndicatorsOfAffiliationForText();

            //logging purposes
            scores.doesDeExist = true;
 
        
            foreach (string word in unrepeatedWords) // the unrepeated word in unknown category
            {
                int break_counter = 0;
                // more semantic comes first
                foreach (KeyValuePair<string, double> wordCategory in tfIdf.OrderByDescending(key => key.Value))
                {

                    break_counter++;
                    if (break_counter >= keyWordsLimit)
                    {
                        break;
                    }
                    //TFIDF unknown category word is wordCateg
                    if (word == wordCategory.Key) // if word from unknown category equals word from category we know
                    {
                        ++scores.commonTerms;
                        scores.normalizedTfidf += wordCategory.Value;
                        
                        if (myDe.words.ContainsKey(wordCategory.Key))
                        {
                            scores.de += myDe.words[word].dispersionEstimation;
                         //   interactor.writeLog(word + ", TFIDF: " + wordCategory.Value + ", DE: " + myDe.words[word].dispersionEstimation);
                        }
                        else
                        {
                            scores.doesDeExist = false;
                            scores.addTermWithBrokenDe(word);
                        }

                    }

                }

            }
            
            return scores;
        }
    }
}
