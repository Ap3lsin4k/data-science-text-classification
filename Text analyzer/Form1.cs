using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_analyzer
{
    public partial class Form1 : Form
    {

        Dictionary<string, WordFreq> texts = new Dictionary<string, WordFreq>();


        public Form1()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            string catg = categoryName.Text; // category
            string peeledText = "";
            

            string news = Regex.Replace(tbNews.Text.ToString(), @"\s+", " ");

            lbRawNews.Text = "";
            lbWords.Text = "";
            lbTf.Text = "";
            peeledText = "";

            foreach (char sumbol in news)
            {
                if (isCyrillic(sumbol))
                    peeledText += Char.ToLower(sumbol);
            }

            peeledText = Regex.Replace(peeledText, @"\s+", " "); // To delete redundant space
//            peeledText = peeledText;

            lbRawNews.Text = peeledText;

            texts[catg] = new WordFreq(peeledText.Split());

            foreach (string word in texts[catg].allWords)
            {
                lbWords.Text += word + "\n";
            
            }
            foreach (string word in texts[catg].allWords)
            {
                if (texts[catg].n.ContainsKey(word))
                {
                    ++texts[catg].n[word];
                }
                else
                {
                    texts[catg].n[word] = 1;
                }

            }

            
            foreach (KeyValuePair<string, int> item in texts[catg].n.OrderByDescending(key => key.Value))
            {
                // do something with item.Key and item.Value
                lbTf.Text += item.Key + " : " + texts[catg].n[item.Key] + ",    "
                    + texts[catg].getTf(item.Key)
                    + "%" + "\n";
            }
            //
        }



        private bool isCyrillic(int letterCode)
        {
            switch(letterCode)
            {
                case 1028: // Є
                case 1108: // є
                case 1030: // І
                case 1110: // і
                case 1168: // Ґ
                case 1169: // ґ
                case 32:  // " "
                case 39:  // '
                //case 45:  // -
                    return true;
                default:
                    return
                        1040 <= letterCode && letterCode <= 1103 &&
                        letterCode != 1066 &&  // Ъ
                        letterCode != 1067 &&  // Ы
                        letterCode != 1099 &&  // ы
                        letterCode != 1098  // ъ
                        ;
            }
              
        }

        private void btnIdf_Click(object sender, EventArgs e)
        {

        }
    }
}


/*
    Кирилиця Десятковий код Шістнадцятеричний код Символ Символьне позначення Ё Ё Ё А А А Б Б Б В В В Г Г Г Д Д Д Е Е Е Ж Ж Ж З З З И И И Й Й Й К К К Л Л Л М М М Н Н Н О О О П П П Р Р Р С С С Т Т Т У У У Ф Ф Ф Х Х Х Ц Ц Ц Ч Ч Ч Ш Ш Ш Щ Щ Щ Ъ Ъ Ъ Ы Ы Ы Ь Ь Ь Э Э Э Ю Ю Ю Я Я Я а а а б б б в в в г г г д д д е е е ж ж ж з з з и и и й й й к к к л л л м м м н н н о о о п п п р р р с с с т т т у у у ф ф ф х х х ц ц ц ч ч ч ш ш ш щ щ щ ъ ы ь э ю я ё 
                  if(1040 <= letterCode && letterCode <= 1103)
                {

                    peeledText += sumbol;
                }   
*/
/*
 * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_analyzer
{
    public partial class Form1 : Form
    {

        private string peeledText = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            string news = tbNews.Text.ToString();

            lbRawNews.Text = "";
            peeledText = "";
            foreach (char sumbol in news)
            {
                int letterCode = (int)sumbol;
                lbRawNews.Text = lbRawNews.Text + letterCode + " ";
                peeledText += sumbol;
            }

            MessageBox.Show(peeledText);
        }



        private bool isCyrillic(int letterCode)
        {
                    

        }
    }
}

/*
    Кирилиця Десятковий код Шістнадцятеричний код Символ Символьне позначення Ё Ё Ё А А А Б Б Б В В В Г Г Г Д Д Д Е Е Е Ж Ж Ж З З З И И И Й Й Й К К К Л Л Л М М М Н Н Н О О О П П П Р Р Р С С С Т Т Т У У У Ф Ф Ф Х Х Х Ц Ц Ц Ч Ч Ч Ш Ш Ш Щ Щ Щ Ъ Ъ Ъ Ы Ы Ы Ь Ь Ь Э Э Э Ю Ю Ю Я Я Я а а а б б б в в в г г г д д д е е е ж ж ж з з з и и и й й й к к к л л л м м м н н н о о о п п п р р р с с с т т т у у у ф ф ф х х х ц ц ц ч ч ч ш ш ш щ щ щ ъ ы ь э ю я ё 
     
*/
