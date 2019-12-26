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
// work with files
using System.IO;

namespace Text_analyzer
{
    public partial class Form1 : Form
    {
        // category, and words in each text
//        Dictionary<string, WordFreq> texts = new Dictionary<string, WordFreq>();
        TextJson newsJson = new TextJson();
        DE myDe = new DE();
        public Form1()
        {
            InitializeComponent();
            load();
        }

        const int keyWordsLimit = 155;
        //we compare from the most key index

       
        

        private void btnTf_Click(object sender, EventArgs e)
        {

            // newsJson = new TextJson();
            string catg = cbCategories.Text;//tbCategoryName.Text; // category

            if(string.IsNullOrWhiteSpace(catg))
            {
                MessageBox.Show("Please enter or chose the category");
                return;
            }

            string toOutToLbWords= "Peeled text:\n", toOutToLbBig ="TF\n";

            lbBig.Text = "";
            
            if (!string.IsNullOrWhiteSpace(rtbKnownText.Text.ToString()))
            {
                string peeledText = getRawText(rtbKnownText.Text.ToString());

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
                lbBig.Text = toOutToLbBig;
                /*
                btnIdf.Enabled = true;
                // calculate TF to all categories and then press IDF. Then TFIDF.
                */
                updateCbCategories();
            }
            else
            {
                if (newsJson.texts.ContainsKey(catg))
                {
                    foreach (string word in newsJson.texts[catg].allWords)
                    {
                        toOutToLbWords += word + "\n";

                    }
                    foreach (KeyValuePair<string, int> item in newsJson.texts[catg].n.OrderByDescending(key => key.Value))
                    {
                        // do something with item.Key and item.Value
                        toOutToLbBig += item.Key + " : " + Math.Round(
                                newsJson.texts[catg].TF[item.Key],
                                2)  // numbers after point
                            + "%" + "\n";
                    }
                    lbBig.Text = toOutToLbBig;
                }
                else
                {
                    MessageBox.Show("The category \"" + catg + "\" was not created. To create this category enter text of news in the TextBox");
                }

            }
        }



        private void idf(string catg, bool log)
        {
            string textToOut = "IDF\n";
            int categories = 0;
            //foreach (WordFreq text in texts.Values)

            foreach (string word in newsJson.texts[catg].n.Keys)
            {
                categories = 1;
                foreach (KeyValuePair<string, WordFreq> text in newsJson.texts)
                {
                    if (text.Key == catg) continue;
                    
                    if(text.Value.n.Keys.Contains(word))
                    {
                        categories++; // if at least a word is in other category we count it and go to another text
                        //break; // don't write break.
                    }
                    
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


        private void btnCategories_LoadTextFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //            openFileDialog1.InitialDirectory = @"\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|Allfiles (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog1.FileName, GetEncoding(openFileDialog1.FileName));//Encoding.UTF8);//Windows-1251
                rtbKnownText.Text = text;
                //openFileDialog1.FileName,
                //                 RichTextBoxStreamType.PlainText);
                //todo call analyse
            }
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

        private string getRawText(string notClearedText)
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


        private List<string> getRawTextSplit(string notClearedText)
        {
            return getRawText(notClearedText).Split().ToList<string>();
        }
        private List<string> getRawTextSplit(TextBox tbWithText)
        {
            return getRawText(tbWithText.Text.ToString()).Split().ToList<string>();
        }

        //      ========PROGRAM_#2========
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            string unknownText = getRawText(richTBtoAnalyze.Text);  // Text with unknown category
            string[] unknownWords = unknownText.Split();
            
            /* TODO clean up
            double wordsCount = 0, wordsCountAvg;

            foreach (WordFreq text in newsJson.texts.Values)
            {
                wordsCount += text.allWords.Count;
            }
            wordsCountAvg = wordsCount / newsJson.texts.Count;
            */

            myGrid.Rows.Clear();

            // all words repeat one time now
            Dictionary<string, int> n = new Dictionary<string, int>();
            foreach (string word in unknownWords)
            {
                if (n.ContainsKey(word)) ++n[word]; 
                else n[word] = 1;

            }
            de();

            foreach (KeyValuePair<string, WordFreq> category in newsJson.texts)  // category, a category properties
            {
                // here we have Category(category.Key) and array of unrepeated words(category.Value.allWords)
                // on the other hand, we have array of repeated words(unknownWords)
                int ind = myGrid.Rows.Add(), countOfCommonElem = 0;
                double score = 0, deScore = 0;
                myGrid.Rows[ind].Cells[0].Value = category.Key;  // category

                Directory.CreateDirectory("log");
                FileInfo f = new FileInfo("log/" + category.Key + ".txt");
                StreamWriter logCommonWords = f.CreateText();
                bool isDeNotFound = false;
                string lastErrorKey = "";
                foreach (string word in n.Keys) // the unrepeated word in unknown category
                {
                    int break_counter = 0;
                    // від найбільш ключових слів до найменш  у категоріях
                    foreach (KeyValuePair<string, double> wordCategory in category.Value.TFIDF.OrderByDescending(key => key.Value))
                    {

                        break_counter++;
                        if (break_counter >= keyWordsLimit)
                        {
                            break;
                        }
                        //TFIDF unknown category word is wordCateg
                        if (word == wordCategory.Key) // if word from unknown category equals word from category we know
                        {;
                            ++countOfCommonElem;
                            score += wordCategory.Value;

                            // must be true DE
                            if (myDe.words.ContainsKey(wordCategory.Key)) {
                                deScore += myDe.words[word].dispersionEstimation;

                                logCommonWords.WriteLine(word + ", TFIDF: " + wordCategory.Value + ", DE: " + myDe.words[word].dispersionEstimation);
                            }
                            else
                            {
                                isDeNotFound = true;
                                lastErrorKey += '"' + word + "\", ";//for debug purposes
                            }

                        }
                        //MessageBox.Show(category.Key + " " + wordCategory.Value + ":"+ wordCategory.Key);

                    }

                }



                //                myGrid.Rows[ind].Cells[1].Value = countOfCommonElem;

               // myGrid.Rows[ind].Cells[1].Value = Math.Round(score, 4);//Math.Round(100.0 * countOfCommonElem / Math.Min(category.Value.TFIDF.Count, keyWordsLimit), 1);
                //(float)100 * countOfCommonElem / (n.Count);  // percent
                myGrid.Rows[ind].Cells[1].Value = Math.Round(score, 4); // imporotance coefficient

                if (isDeNotFound)
                {

                    MessageBox.Show("The key(s) " + lastErrorKey + "was not found in the Dictinary of DispersionEstimation");

                }
                else { 
               
                    myGrid.Rows[ind].Cells[2].Value = Math.Round(deScore, 4); // imporotance coefficient
                    myGrid.Rows[ind].Cells[3].Value = Math.Round(score*deScore, 4); // imporotance coefficient

                }
                // end writing log
                logCommonWords.Close();
            }

            // sorting by importance coeffficent
            myGrid.Sort(myGrid.Columns[1], ListSortDirection.Descending);

            // TODO вставляти вже відсортовані данні
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


        private void de()
        {
           // string peeledText = getRawText(richTBtoAnalyze.Text.ToString());//todo optimise speed
            string resultOfDispersionEstimation = myDe.analyzeDE(getRawTextSplit(richTBtoAnalyze.Text));
            lbDEresult.Text = resultOfDispersionEstimation.ToString();
        }

        private void btnDE_Click(object sender, EventArgs e)
        {
            de();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            newsJson.save();
            /*FileInfo f = new FileInfo("Mytext.txt");
            StreamWriter logCommonWords = f.CreateText();
            logCommonWords.WriteLine("This is from");
            logCommonWords.WriteLine("Chapter 6");
            logCommonWords.WriteLine("Of C# Module");
            logCommonWords.Write(logCommonWords.NewLine);
            logCommonWords.WriteLine("Thanks for your time");
            logCommonWords.Close();*/
            // TODO cosmetic print that saved
            MessageBox.Show("Success");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(load())
                MessageBox.Show("Successfully loaded from \"analysis.json\"");
            // error message prints in the newsJson.load().catch
        }


        private void updateCbCategories()
        {
            cbCategories.Items.Clear();
            cbCategories.Items.AddRange(newsJson.texts.Keys.ToArray());
        }

        private bool load()
        {
            bool success;
            success = newsJson.load();
            updateCbCategories();
            return success;
        }

        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            string allCategories="All categories:\n";
            foreach (string category in newsJson.texts.Keys)
            {
                allCategories += category + "\n";
            }
          //  lbWords.Text = allCategories;
//            MessageBox.Show(allCategories);
        }

       





        /// <summary>
        /// Determines a text file's encoding by analyzing its byte order mark (BOM).
        /// Defaults to ASCII when detection of the text file's endianness fails.
        /// </summary>
        /// <param name="filename">The text file to analyze.</param>
        /// <returns>The detected encoding.</returns>
        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.Default;  // ANSI
        }

        private void btnLoadTextFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
//            openFileDialog1.InitialDirectory = @"\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|Allfiles (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog1.FileName, GetEncoding(openFileDialog1.FileName));//Encoding.UTF8);//Windows-1251
                richTBtoAnalyze.Text = text;
                //openFileDialog1.FileName,
                //                 RichTextBoxStreamType.PlainText);
                //todo call analyse
            }

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
            string news = rtbKnownText.Text.ToString();

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
