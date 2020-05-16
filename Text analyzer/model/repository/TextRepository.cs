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

            peeledText = Regex.Replace(peeledText, @"\s+", " "); // To delete redundant space
                                                                 //            peeledText = peeledText;


            return peeledText;
        }


        public List<string> getRawTextSplit(string notClearedText)
        {
            return getRawText(notClearedText).Split().ToList<string>();
        }
        public List<string> getRawTextSplit(TextBox tbWithText)
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
                        letterCode != 1099 &&  // ы
                        letterCode != 1098  // ъ
                        ;
            }

        }
    }
}
