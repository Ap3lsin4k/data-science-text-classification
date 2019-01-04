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
        // category, and words in each text
//        Dictionary<string, WordFreq> texts = new Dictionary<string, WordFreq>();
        TextJson newsJson = new TextJson();

        public Form1()
        {
            InitializeComponent();
            load();
        }

       
        

        private void btnTf_Click(object sender, EventArgs e)
        {

            // newsJson = new TextJson();
            string catg = cbCategories.Text;//tbCategoryName.Text; // category
            string toOutToLbWords= "Peeled text:\n", toOutToLbBig ="TF\n";

            lbWords.Text = "";// TODO tf to log
            lbBig.Text = "";

            string peeledText = getRawText(tbNews.Text.ToString());
            
            // create text with new category, if it wasn't created still
            newsJson.texts[catg] = new WordFreq(peeledText.Split().ToList<string>());  // TODO test: casting to List can take much time

            foreach (string word in newsJson.texts[catg].allWords)
            {
                toOutToLbWords += word + "\n";
            
            }
            foreach (string word in newsJson.texts[catg].allWords)
            {
                if (newsJson.texts[catg].n.ContainsKey(word))
                {
                    ++newsJson.texts[catg].n[word];
                }
                else
                {
                    newsJson.texts[catg].n[word] = 1;
                }

            }

                
            // TF
            foreach (KeyValuePair<string, int> item in newsJson.texts[catg].n.OrderByDescending(key => key.Value))
            {
                // do something with item.Key and item.Value
                toOutToLbBig += item.Key + " : " + newsJson.texts[catg].n[item.Key] + ",    "
                    + Math.Round(
                        newsJson.texts[catg].calcTf(item.Key),
                        2)  // numbers after point
                    + "%" + "\n";
            }
            lbWords.Text = toOutToLbWords;
            lbBig.Text = toOutToLbBig;
            /*
            btnIdf.Enabled = true;
            // calculate TF to all categories and then press IDF. Then TFIDF.
            */
            updateCbCategories();
        }



        private void idf(string catg, bool log)
        {
            string textToOut = "IDF\n";
            int categories = 0;
            //foreach (WordFreq text in texts.Values)

            foreach (string word in newsJson.texts[catg].allWords)
            {
                categories = 1;
                foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)
                {
                    if (text.Key == catg) continue;
                    /*
                    //if (word in text.Value.allWords)
                    string sequence = text.Value.allWords.Where(x => x == word).FirstOrDefault();
                    //foreach (string commonWord in sequence)
                    if(sequence != null)
                    {
                        categories++;
                        break;
                        //MessageBox.Show(sequence);
                    }
                    //*/
                    //*
                    foreach (string wordInOtherTexts in text.Value.n.Keys)
                    {
                        if (word == wordInOtherTexts)
                        {
                            categories++; // if at least a word is in other category we count it and go to another text
                            break;
                        }
                    }
                    //*/
                }
                textToOut += word + ":" +
                newsJson.texts[catg].calcIdf(word, newsJson.texts.Count, categories).ToString("0.####")  // word, Number of all texts, Number of text which contain this word
                + "\n";
                /* IDF*/
            }

            if (log) lbBig.Text = textToOut;
        }

        private void btnIdf_Click(object sender, EventArgs e)
        {
            lbBig.Text = "IDF chose existed category to see more\n";
            string catg = cbCategories.Text; //tbCategoryName.Text; // category
            if (newsJson.texts.Count != 0)
            {
                // calculate IDF for each category
                foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)
                {
                    idf(text.Key, text.Key == catg);// write log when current category.
                }
            }
            else
                MessageBox.Show("Here is no categories to calculate Inverse Document Frequency");
            /*
            if(newsJson.texts[catg].flagTf && newsJson.texts[catg].flagIdf)
            {
                btnTfIdf.Enabled = true;
            }
        */  
        }

        private void tfIdf(string catg, bool log)
        {
            string toOutLbBig = "TFIDF\n";

            newsJson.texts[catg].calcTfIdf();

            foreach (KeyValuePair<string, double> wordTI in newsJson.texts[catg].TFIDF.OrderByDescending(key => key.Value))
            {
                toOutLbBig += wordTI.Key + " : " + (wordTI.Value).ToString("0.####") + "\n"; ;
            }
            if (log) lbBig.Text = toOutLbBig;  
        }

        private void btnTfIdf_Click(object sender, EventArgs e)
        {
            lbBig.Text = "TFIDF please chose existed category to see more\n";

            string catg = cbCategories.Text; //tbCategoryName.Text; // category
            if (newsJson.texts.Count != 0)
            {
            
                // TODO simplify KeyValuePair<> to string
                foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)
                {
                    if (newsJson.texts[text.Key].flagTf && newsJson.texts[text.Key].flagIdf)
                    {
                        tfIdf(text.Key, text.Key == catg);
                    }
                    else
                    {
                        MessageBox.Show("Error. Please click TF for \"" + catg + "\" category. " +
                            "Than you should click on IDF. " +
                            "Finally click TFIDF to get it");
                    }
                }
            }
            else
                MessageBox.Show("Here is no categories to calculate TF*IDF");
        }

        private bool isCyrillic(int letterCode)
        {
            switch (letterCode)
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

        private string getRawText(string notClearedText)
        {
            string news = Regex.Replace(notClearedText, @"\s+", " ");
            string peeledText = "";


            foreach (char sumbol in news)
            {
                if (isCyrillic(sumbol))
                    peeledText += Char.ToLower(sumbol);
                else
                    peeledText += " ";
            }

            peeledText = Regex.Replace(peeledText, @"\s+", " "); // To delete redundant space
                                                                 //            peeledText = peeledText;


            return peeledText;
        }

        //      ========PROGRAM_#2========
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            string unknownText = getRawText(tbNewText.Text);  // Text with unknown category
            string[] unknownWords = unknownText.Split();
            
            double wordsCount = 0;

            foreach (WordFreq text in newsJson.texts.Values)
            {
                wordsCount += text.allWords.Count;
            }
            double wordsCountAvg = wordsCount / newsJson.texts.Count;

            myGrid.Rows.Clear();

            // all words repeat one time now
            Dictionary<string, int> n = new Dictionary<string, int>();
            foreach (string word in unknownWords)
            {
                if (n.ContainsKey(word)) ++n[word]; 
                else n[word] = 1;

            }

            foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)  // category, a text properties
            {
                // here we have Category(text.Key) and array of unrepeated words(text.Value.allWords)
                // on the other hand, we have array of repeated words(unknownWords)
                int ind = myGrid.Rows.Add(), countOfCommonElem = 0;
                double score =0;
                myGrid.Rows[ind].Cells[0].Value = text.Key;  // category
            

                foreach (string word in n.Keys) // the unrepeated word
                {
                    int break_counter = 0;
                    
                    foreach (KeyValuePair<string, double> wordCategory in text.Value.TFIDF.OrderByDescending(key => key.Value))
                    {

                        break_counter++;
                        if (break_counter >= 200)
                        {
                            break;
                        }
                        if (word == wordCategory.Key) // if word from unknown category equals word from category we know
                        {
                            ++countOfCommonElem;
                            score += wordCategory.Value;
                           // MessageBox.Show(text.Key + " " + word+":"+ wordCategory.Value);
                        }
                        //MessageBox.Show(text.Key + " " + wordCategory.Value + ":"+ wordCategory.Key);

                    }

                }
                myGrid.Rows[ind].Cells[1].Value = countOfCommonElem;  // category
                myGrid.Rows[ind].Cells[2].Value = (float)100 *
                    countOfCommonElem
                    /
                    (n.Count); // + text.Value.n.Count - countOfCommonElem);
                               /*/ 
                               (unknownWords.Length + text.Value.allWords.Length-countOfCommonElem) ;
                               */
                myGrid.Rows[ind].Cells[3].Value = score / text.Value.TFIDF.Count * wordsCountAvg; // improtance coefficient


            }
            //TODO sort
           // DataGridViewColumn newColumn =
            /*
            myGrid.Columns.GetColumnCount(
            DataGridViewElementStates.Selected)
            == 1
            ? myGrid.SelectedColumns[0]
             : null;
            //*/

            //ListSortDirection direction = ListSortDirection.Ascending;
            /*if (newColumn!= null)
                    myGrid.Sort(myGr, direction);
            else
                MessageBox.Show("Select a single column and try again.",
                "Error: Invalid Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Error);*/
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            newsJson.save();
            /*FileInfo f = new FileInfo("Mytext.txt");
            StreamWriter w = f.CreateText();
            w.WriteLine("This is from");
            w.WriteLine("Chapter 6");
            w.WriteLine("Of C# Module");
            w.Write(w.NewLine);
            w.WriteLine("Thanks for your time");
            w.Close();*/
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            newsJson.load();
            updateCbCategories();
        }

        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            string allCategories="All categories:\n";
            foreach (string category in newsJson.texts.Keys)
            {
                allCategories += category + "\n";
            }
            lbWords.Text = allCategories;
//            MessageBox.Show(allCategories);
        }

        private void updateCbCategories()
        {
            cbCategories.Items.Clear();
            cbCategories.Items.AddRange(newsJson.texts.Keys.ToArray());
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
