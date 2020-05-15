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
    }
}
