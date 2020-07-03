using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PupilIsNotStudent.model.repository
{

    class TextParsingRepository
    {

        //==========TEXT PARSER==========
        // only Cyrillic letters. Change separators to only one " "
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


        // Takes not cleared(aka raw) text
        public string[] getSplitWords(string notClearedText)
        {
            return getRawText(notClearedText).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }


        private List<string> getRawTextSplit(string notClearedText)
        {
            return getRawText(notClearedText).Split().ToList<string>();
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
                default:
                    return
                        1040 <= letterCode && letterCode <= 1103 &&  // Cyrillic
                        letterCode != 1066 &&  // Ъ
                        letterCode != 1067 &&  // Ы
                        letterCode != 1098  // ъ
                        ||
                        65 <= letterCode && letterCode <= 90
                        ||
                        97 <= letterCode && letterCode <= 122
                        ;
            }

        }

        // ==========TEXT ANALYZER==========
        // To Extract Key Words Repository
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





    }
}
