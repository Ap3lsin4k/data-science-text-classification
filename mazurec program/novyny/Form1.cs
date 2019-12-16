using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace novyny
{
    public partial class Form1 : Form
    {
        public List<string> txt(string nazva, List<string> lines)
        {
            //string []b=File.ReadAllLines(@nazva, Encoding.Default);
            string[] b = File.ReadAllText(@nazva, Encoding.Default).
                 Split(new Char[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for(int i=0;i<b.Length;i++)
            {
                lines.Add(b[i]);
            }
            return lines;
        }

        //string[] mas = { ";", ",", ".", "—", ":", "?", "(", ")", "!", Convert.ToString('"'), "/", "«", "»",
        //                   "1","2","3","4","5","6","7","8","9","0","\n","–","\r","-"};
        string[] mas = { "\'", "-" };
        #region data
        Text t = new Text();
        Sum Count = new Sum();
        Categories Kategor = new Categories();
        List<string> text1 = new List<string>();
        List<string> text2 = new List<string>();
        List<string> text3 = new List<string>();
        List<string> text4 = new List<string>();
        List<string> text5 = new List<string>();
        List<string> text6 = new List<string>();
        List<string> text7 = new List<string>();
        List<string> test_text = new List<string>();
        string[] mas_text;
        string text_new = "";
        int zagal_kilk = 0;
        int number_vkl = 0;
        int k = 0;
        string text;
        int[] index;
        string[,] mas_ob_;
        double[] rezerv;
        double temp; int temp_ind;

        string[] nowy_mas_test;
        string[] nowy_mas;
        string[] nowy_mas_2;
        string[] nowy_mas_3;
        string[] nowy_mas_4;
        string[] nowy_mas_5;
        string[] nowy_mas_6;
        string[] nowy_mas_7;

   
        string[,] mas_ob_1;
        string[,] mas_ob_2;
        string[,] mas_ob_3;
        string[,] mas_ob_4;
        string[,] mas_ob_5;
        string[,] mas_ob_6;
        string[,] mas_ob_7;

        string[] mas1;
        double[] chast_;
        string[] mas2;
        double[] chast_2;
        int[] mas_kilk2;
        string[] mas3;
        double[] chast_3;
        int[] mas_kilk3;
        string[] mas4;
        double[] chast_4;
        int[] mas_kilk4;
        string[] mas5;
        double[] chast_5;
        int[] mas_kilk5;
        string[] mas6;
        double[] chast_6;
        int[] mas_kilk6;
        string[] mas7;
        double[] chast_7;
        int[] mas_kilk7;
        int[] mas_kilk_;
        int len = 0,i_len=0;

        int[] mas_kilk;
        int[] mas_kilk_2;
        int[] mas_kilk_3;
        int[] mas_kilk_4;
        int[] mas_kilk_5;
        int[] mas_kilk_6;
        int[] mas_kilk_7;

        int[] kilk_text;
        string txt1, txt2,txt3,txt4,txt5,txt6;
        string[] mas_text2;
        string[] mas_text3;
        string[] mas_text4;
        string[] mas_text5;
        string[] mas_text6;
        string[] mas_text7;
     
        double[] chast;
        double[] chast2;
        double[] chast3;
        double[] chast4;
        double[] chast5;
        double[] chast6;
        double[] chast7;

        double[] idf1;
        double[] tf_idf1;

        double[] idf2;
        double[] tf_idf2;

        double[] idf3;
        double[] tf_idf3;

        double[] idf4;
        double[] tf_idf4;

        double[] idf5;
        double[] tf_idf5;

        double[] idf6;
        double[] tf_idf6;

        double[] idf7;
        double[] tf_idf7;

        int len_for_kat=30;
        int obm = 1; int len_gr;
        Methods Met = new Methods();
        #endregion
        public Form1()
        {
            InitializeComponent();
            tabControl2.DrawItem += new DrawItemEventHandler(tabControl2_DrawItem);
            #region pbox
          
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;

            #endregion
            string nazva;
            #region txt kategorii
            nazva = "Політика.txt";
            txt(nazva, text1);
            textBox1.Text = nazva;
            for (int i = 0; i < text1.Count;i++ )
                    richTextBox1.AppendText(text1[i].ToString() + " ");           

            nazva = "Економіка.txt";
            txt(nazva, text2);
            textBox2.Text = nazva;
            for (int i = 0; i < text2.Count; i++)
                richTextBox4.AppendText(text2[i].ToString() + " ");

            nazva = "Погода.txt";
            txt(nazva, text3);
            textBox7.Text = nazva;
            for (int i = 0; i < text3.Count; i++)
                richTextBox7.AppendText(text3[i].ToString() + " ");


            nazva = "Наука та ІТ.txt";
            txt(nazva, text4);
            textBox8.Text = nazva;
            for (int i = 0; i < text4.Count; i++)
                richTextBox10.AppendText(text4[i].ToString() + " ");

            nazva = "Світ.txt";
            txt(nazva, text5);
            textBox10.Text = nazva;
            for (int i = 0; i < text5.Count; i++)
                richTextBox18.AppendText(text5[i].ToString() + " ");

            nazva = "Спорт.txt";
            txt(nazva, text6);
            textBox12.Text = nazva;
            for (int i = 0; i < text6.Count; i++)
                richTextBox21.AppendText(text6[i].ToString() + " ");

            nazva = "Здоров'я.txt";
            txt(nazva, text7);
            textBox14.Text = nazva;
            for (int i = 0; i < text7.Count; i++)
                richTextBox24.AppendText(text7[i].ToString() + " ");

            #endregion

            richTextBox14.Text = richTextBox4.Text;
            richTextBox13.Text = richTextBox7.Text;
            richTextBox25.Text = richTextBox10.Text;
            richTextBox26.Text = richTextBox18.Text;
            richTextBox27.Text = richTextBox21.Text;
            richTextBox28.Text = richTextBox24.Text;
        }
        //запис tf_idf 2 вкладка
        public  string [,]  grid(string []nowy_mas,double[]chast_i,double [] idf,double [] tf_idf)
        {
             mas_ob_ = new string[nowy_mas.Length, 4];
            index=new int [nowy_mas.Length];
            rezerv=new double[tf_idf.Length];
            for (int i = 0; i < tf_idf.Length;i++ )
            {
                tf_idf[i] = chast_i[i] * idf[i];
                rezerv[i] = tf_idf[i];
                index[i] = i;
            }

           //сортування
            for (int j = 0; j < rezerv.Length-1; j++)
            {
                for (int i = j+1; i < rezerv.Length; i++)
                {
                    if (rezerv[j] * (-1) > rezerv[i] * (-1))
                    {
                        temp = rezerv[j];
                        temp_ind = index[j];

                        rezerv[j] = rezerv[i];
                        index[j] = index[i];

                        rezerv[i] = temp;
                        index[i] = temp_ind;
                    }
                }
            }

            for (int i = 0; i < rezerv.Length; i++)
            {
                mas_ob_[i, 0] = nowy_mas[index[i]];
                mas_ob_[i, 1] = chast_i[index[i]].ToString();
                mas_ob_[i, 2] = idf[index[i]].ToString();
                mas_ob_[i, 3] = rezerv[i].ToString();
            }
            return mas_ob_;
        }
        public void grid_vyvod(string[,] mas_ob_mas,int len_gr)
            {
            dataGridView3.RowCount = len_gr;
                for (int i = 0; i < len_gr; i++)
                {
                    dataGridView3.Rows[i].Cells[0].Value = mas_ob_mas[i, 0];
                    dataGridView3.Rows[i].Cells[1].Value = mas_ob_mas[i, 1];
                    dataGridView3.Rows[i].Cells[2].Value = mas_ob_mas[i, 2];
                    dataGridView3.Rows[i].Cells[3].Value = mas_ob_mas[i, 3];
                }
            
        }
        
        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl2.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl2.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

        }
        private void tabControl3_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl3.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl3.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));



            if (tabControl3.SelectedIndex == 0)
            {
                label9.Text = tabPage11.Text; 
                richTextBox14.Text = richTextBox4.Text;
                richTextBox13.Text = richTextBox7.Text; 
                richTextBox25.Text=richTextBox10.Text;
                richTextBox26.Text=richTextBox18.Text;
                richTextBox27.Text=richTextBox21.Text;
                richTextBox28.Text = richTextBox24.Text;
                number_vkl = 0;
            }

            if (tabControl3.SelectedIndex == 1)
            {
                label9.Text = tabPage12.Text; number_vkl = 1; 
                richTextBox14.Text = richTextBox1.Text;
                richTextBox13.Text = richTextBox7.Text;
                richTextBox25.Text = richTextBox10.Text;
                richTextBox26.Text = richTextBox18.Text;
                richTextBox27.Text = richTextBox21.Text;
                richTextBox28.Text = richTextBox24.Text;
            }
            if (tabControl3.SelectedIndex == 2)
            {
                label9.Text = tabPage13.Text; number_vkl = 2; 
                richTextBox14.Text = richTextBox1.Text;
                richTextBox13.Text = richTextBox4.Text;
                richTextBox25.Text = richTextBox10.Text;
                richTextBox26.Text = richTextBox18.Text;
                richTextBox27.Text = richTextBox21.Text;
                richTextBox28.Text = richTextBox24.Text;
            }
            if (tabControl3.SelectedIndex == 3)
            {
                label9.Text = tabPage14.Text; number_vkl = 3; 
                richTextBox14.Text = richTextBox1.Text;
                richTextBox13.Text = richTextBox4.Text;
                richTextBox25.Text = richTextBox7.Text;
                richTextBox26.Text = richTextBox18.Text;
                richTextBox27.Text = richTextBox21.Text;
                richTextBox28.Text = richTextBox24.Text;
            }
            if (tabControl3.SelectedIndex == 4)
            {
                label9.Text = tabPage15.Text; number_vkl = 4; 
                richTextBox14.Text = richTextBox1.Text;
                richTextBox13.Text = richTextBox4.Text;
                richTextBox25.Text = richTextBox7.Text;
                richTextBox26.Text = richTextBox10.Text;
                richTextBox27.Text = richTextBox21.Text;
                richTextBox28.Text = richTextBox24.Text;
            }
            if (tabControl3.SelectedIndex == 5)
            {
                label9.Text = tabPage16.Text; number_vkl = 5; 
                richTextBox14.Text = richTextBox1.Text;
                richTextBox13.Text = richTextBox4.Text;
                richTextBox25.Text = richTextBox7.Text;
                richTextBox26.Text = richTextBox10.Text;
                richTextBox27.Text = richTextBox18.Text;
                richTextBox28.Text = richTextBox24.Text;
            }
            if (tabControl3.SelectedIndex == 6)
            {
                label9.Text = tabPage17.Text; number_vkl = 6; 
                richTextBox14.Text = richTextBox1.Text;
                richTextBox13.Text = richTextBox4.Text;
                richTextBox25.Text = richTextBox7.Text;
                richTextBox26.Text = richTextBox10.Text;
                richTextBox27.Text = richTextBox18.Text;
                richTextBox28.Text = richTextBox21.Text;
            }

            if (number_vkl == 0)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas.Length;
                grid_vyvod(mas_ob_1,len_gr);
            }

            if (number_vkl == 1)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_2.Length;
                grid_vyvod(mas_ob_2,len_gr);
            }

            if (number_vkl == 2)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_3.Length;
                grid_vyvod(mas_ob_3,len_gr);
            }
            if (number_vkl == 3)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_4.Length;
                grid_vyvod(mas_ob_4,len_gr);
            }
            if (number_vkl == 4)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_5.Length;
                grid_vyvod(mas_ob_5,len_gr);
            }
            if (number_vkl == 5)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_6.Length;
                grid_vyvod(mas_ob_6,len_gr);
            }
            if (number_vkl == 6)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_7.Length;
                grid_vyvod(mas_ob_7,len_gr);
            }
            }
        private void button1_Click(object sender, EventArgs e)
        {
           
            #region pbox
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            #endregion
            checkBox2.Visible= true;
            #region tab1

            string text = richTextBox1.Text.ToLower();

            mas_text = t.txt1(text, mas, text_new);
            text_new = "";

            text1.Clear();
            for (int i = 0; i < mas_text.Length; i++)
            {
                text1.Add(mas_text[i]);
                mas_text[i] = "";

            }
            for (int i = 0; i < text1.Count; i++)
            {
                if (text1[i] == "\n" || text1[i] == " " || text1[i] == "" || string.IsNullOrEmpty(text1[i]))
                {
                    text1.Remove(text1[i]);
                }
                else
                {
                    richTextBox2.AppendText(text1[i] + "\n");
                    richTextBox3.AppendText(text1[i].ToString() + " ");
                    mas_text[k] = text1[i];
                    k++;
                }
            }
             mas_kilk = new int[mas_text.Length];
            string[] mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;

            nowy_mas = t.mas(mas_text, mas_slova, mas_kilk);

            for (int i = 0; i < nowy_mas.Length; i++)
            {
                zagal_kilk += mas_kilk[i];
            }

            //Chastota
            chast = new double[nowy_mas.Length];
            Met.tf(nowy_mas, mas_kilk, zagal_kilk, chast);

            textBox3.Text = (zagal_kilk - mas_kilk[nowy_mas.Length - 1]).ToString();

            for (int i = 0; i < mas_text.Length; i++)
            {
                mas_text[i] = "";

            }
            i_len = 0;
            for (int i = 0; i < nowy_mas.Length; i++)
            {
                if (mas_kilk[i] > 1)
                { i_len++; }
            }
            
            mas1 = new string[i_len];
            chast_ = new double[i_len];
            mas_kilk_ = new int[i_len];
            grid2_0(nowy_mas, mas_kilk, chast, mas1, chast_, mas_kilk_);
            grid2_0_v(dataGridView1, mas1, mas_kilk_, chast_);
           

            #endregion
            #region tab1_2
            k = 0;

            text = richTextBox4.Text.ToLower();

            mas_text = t.txt1(text, mas, text_new);
            text_new = "";

            text2.Clear();

            for (int i = 0; i < mas_text.Length; i++)
            {
                text2.Add(mas_text[i]);
                mas_text[i] = "";

            }

            for (int i = 0; i < text2.Count; i++)
            {
                if (text2[i] == "\n" || text2[i] == " " || text2[i] == "" || string.IsNullOrEmpty(text2[i]))
                {
                    text2.Remove(text2[i]);
                }
                else
                {
                    richTextBox5.AppendText(text2[i] + "\n");
                    richTextBox6.AppendText(text2[i].ToString() + " ");
                    mas_text[k] = text2[i];
                    k++;
                }
            }
             mas_kilk_2 = new int[mas_text.Length];
            mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;
            nowy_mas_2 = t.mas(mas_text, mas_slova, mas_kilk_2);
         

            for (int i = 0; i < nowy_mas_2.Length; i++)
            {
                zagal_kilk += mas_kilk_2[i];

            }
            //Chastota
            chast2 = new double[nowy_mas_2.Length];
            Met.tf(nowy_mas_2, mas_kilk_2, zagal_kilk, chast2);
            

            textBox4.Text = (zagal_kilk - mas_kilk_2[nowy_mas_2.Length - 1]).ToString();

            i_len = 0;
            for (int i = 0; i < nowy_mas_2.Length; i++)
            {
                if (mas_kilk_2[i] > 1)
                { i_len++; }
            }
           
            mas2 = new string[i_len];
            chast_2 = new double[i_len];
            mas_kilk2 = new int[i_len];
            grid2_0(nowy_mas_2, mas_kilk_2, chast2, mas2, chast_2, mas_kilk2);
            grid2_0_v(dataGridView2, mas2, mas_kilk2, chast_2);
          

            #endregion
            #region tab1_3
            k = 0;
            text = richTextBox7.Text.ToLower();

            mas_text = t.txt1(text, mas, text_new);
            text_new = "";

            text3.Clear();

            for (int i = 0; i < mas_text.Length; i++)
            {
                text3.Add(mas_text[i]);
                mas_text[i] = "";

            }

            for (int i = 0; i < text3.Count; i++)
            {
                if (text3[i] == "\n" || text3[i] == " " || text3[i] == "" || string.IsNullOrEmpty(text3[i]))
                {
                    text3.Remove(text3[i]);
                }
                else
                {
                    richTextBox8.AppendText(text3[i] + "\n");
                    richTextBox9.AppendText(text3[i].ToString() + " ");
                    mas_text[k] = text3[i];
                    k++;
                }
            }
            mas_kilk_3 = new int[mas_text.Length];
            mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;
            nowy_mas_3 = t.mas(mas_text, mas_slova, mas_kilk_3);

           

            for (int i = 0; i < nowy_mas_3.Length; i++)
            {
                zagal_kilk += mas_kilk_3[i];
            }
            //Chastota
            chast3 = new double[nowy_mas_3.Length];
            Met.tf(nowy_mas_3, mas_kilk_3, zagal_kilk, chast3);


            textBox5.Text = (zagal_kilk - mas_kilk_3[nowy_mas_3.Length - 1]).ToString();
            i_len=0;
            for (int i = 0; i < nowy_mas_3.Length; i++)
            {
                if (mas_kilk_3[i] > 1)
                { i_len++; }
            }

            mas3 = new string[i_len];
            chast_3 = new double[i_len];
            mas_kilk3 = new int[i_len];
            grid2_0(nowy_mas_3, mas_kilk_3, chast3, mas3, chast_3, mas_kilk3);
            grid2_0_v(dataGridView5, mas3, mas_kilk3, chast_3);
          

            #endregion
            #region tab1_4
            k = 0;
            text = richTextBox10.Text.ToLower();

            mas_text = t.txt1(text, mas, text_new);
            text_new = "";

            text4.Clear();

            for (int i = 0; i < mas_text.Length; i++)
            {
                text4.Add(mas_text[i]);
                mas_text[i] = "";

            }

            for (int i = 0; i < text4.Count; i++)
            {
                if (text4[i] == "\n" || text4[i] == " " || text4[i] == "" || string.IsNullOrEmpty(text4[i]))
                {
                    text4.Remove(text4[i]);
                }
                else
                {
                    richTextBox11.AppendText(text4[i] + "\n");
                    richTextBox12.AppendText(text4[i].ToString() + " ");
                    mas_text[k] = text4[i];
                    k++;
                }
            }
             mas_kilk_4 = new int[mas_text.Length];
            mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;
            nowy_mas_4 = t.mas(mas_text, mas_slova, mas_kilk_4);

            for (int i = 0; i < nowy_mas_4.Length; i++)
            {
                zagal_kilk += mas_kilk_4[i];

            }
            //Chastota
            chast4 = new double[nowy_mas_4.Length];
            Met.tf(nowy_mas_4, mas_kilk_4, zagal_kilk, chast4);
       
            textBox6.Text = (zagal_kilk - mas_kilk_4[nowy_mas_4.Length - 1]).ToString();
            i_len = 0;
            for (int i = 0; i < nowy_mas_4.Length; i++)
            {
                if (mas_kilk_4[i] > 1)
                { i_len++; }
            }

            mas4 = new string[i_len];
            chast_4 = new double[i_len];
            mas_kilk4 = new int[i_len];
            grid2_0(nowy_mas_4, mas_kilk_4, chast4, mas4, chast_4, mas_kilk4);
            grid2_0_v(dataGridView7, mas4, mas_kilk4, chast_4);
          
            #endregion
            #region tab1_5
            k = 0;
            text = richTextBox18.Text.ToLower();

            mas_text = t.txt1(text, mas, text_new);
            text_new = "";

            text5.Clear();

            for (int i = 0; i < mas_text.Length; i++)
            {
                text5.Add(mas_text[i]);
                mas_text[i] = "";

            }

            for (int i = 0; i < text5.Count; i++)
            {
                if (text5[i] == "\n" || text5[i] == " " || text5[i] == "" || string.IsNullOrEmpty(text5[i]))
                {
                    text5.Remove(text5[i]);
                }
                else
                {
                    richTextBox17.AppendText(text5[i] + "\n");
                    richTextBox16.AppendText(text5[i].ToString() + " ");
                    mas_text[k] = text5[i];
                    k++;
                }
            }
             mas_kilk_5 = new int[mas_text.Length];
            mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;
            nowy_mas_5 = t.mas(mas_text, mas_slova, mas_kilk_5);


            for (int i = 0; i < nowy_mas_5.Length; i++)
            {
                zagal_kilk += mas_kilk_5[i];

            }
            //Chastota
            chast5 = new double[nowy_mas_5.Length];
            Met.tf(nowy_mas_5, mas_kilk_5, zagal_kilk, chast5);
          

            textBox9.Text = (zagal_kilk - mas_kilk_5[nowy_mas_5.Length - 1]).ToString();

            i_len = 0;
            for (int i = 0; i < nowy_mas_5.Length; i++)
            {
                if (mas_kilk_5[i] > 1)
                { i_len++; }
            }

            mas5 = new string[i_len];
            chast_5 = new double[i_len];
            mas_kilk5 = new int[i_len];
            grid2_0(nowy_mas_5, mas_kilk_5, chast5, mas5, chast_5, mas_kilk5);
            grid2_0_v(dataGridView10, mas5, mas_kilk5, chast_5);

            #endregion
            #region tab1_6
            k = 0;
            text = richTextBox21.Text.ToLower();

            mas_text = t.txt1(text, mas, text_new);
            text_new = "";

            text6.Clear();

            for (int i = 0; i < mas_text.Length; i++)
            {
                text6.Add(mas_text[i]);
                mas_text[i] = "";

            }

            for (int i = 0; i < text6.Count; i++)
            {
                if (text6[i] == "\n" || text6[i] == " " || text6[i] == "" || string.IsNullOrEmpty(text6[i]))
                {
                    text6.Remove(text6[i]);
                }
                else
                {
                    richTextBox20.AppendText(text6[i] + "\n");
                    richTextBox19.AppendText(text6[i].ToString() + " ");
                    mas_text[k] = text6[i];
                    k++;
                }
            }
           mas_kilk_6 = new int[mas_text.Length];
            mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;
            nowy_mas_6 = t.mas(mas_text, mas_slova, mas_kilk_6);

            for (int i = 0; i < nowy_mas_6.Length; i++)
            {
                zagal_kilk += mas_kilk_6[i];
            }
            //Chastota
            chast6 = new double[nowy_mas_6.Length];
            Met.tf(nowy_mas_6, mas_kilk_6, zagal_kilk, chast6);
           
            textBox11.Text = (zagal_kilk - mas_kilk_6[nowy_mas_6.Length - 1]).ToString();
            i_len = 0;
            for (int i = 0; i < nowy_mas_6.Length; i++)
            {
                if (mas_kilk_6[i] > 1)
                { i_len++; }
            }

            mas6 = new string[i_len];
            chast_6 = new double[i_len];
            mas_kilk6 = new int[i_len];
            grid2_0(nowy_mas_6, mas_kilk_6, chast6, mas6, chast_6, mas_kilk6);
            grid2_0_v(dataGridView11, mas6, mas_kilk6, chast_6);

            #endregion
            #region tab1_7
            k = 0;
            text = richTextBox24.Text.ToLower();

            mas_text = t.txt1(text, mas, text_new);
            text_new = "";

            text7.Clear();

            for (int i = 0; i < mas_text.Length; i++)
            {
                text7.Add(mas_text[i]);
                mas_text[i] = "";

            }

            for (int i = 0; i < text7.Count; i++)
            {
                if (text7[i] == "\n" || text7[i] == " " || text7[i] == "" || string.IsNullOrEmpty(text7[i]))
                {
                    text7.Remove(text7[i]);
                }
                else
                {
                    richTextBox23.AppendText(text7[i] + "\n");
                    richTextBox22.AppendText(text7[i].ToString() + " ");
                    mas_text[k] = text7[i];
                    k++;
                }
            }
            mas_kilk_7 = new int[mas_text.Length];
            mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;
            nowy_mas_7 = t.mas(mas_text, mas_slova, mas_kilk_7);

            for (int i = 0; i < nowy_mas_7.Length; i++)
            {
               zagal_kilk += mas_kilk_7[i];
            }
            //Chastota
            chast7 = new double[nowy_mas_7.Length];
            Met.tf(nowy_mas_7, mas_kilk_7, zagal_kilk, chast7);
       

            textBox13.Text = (zagal_kilk - mas_kilk_7[nowy_mas_7.Length - 1]).ToString();
            i_len = 0;
            for (int i = 0; i < nowy_mas_7.Length; i++)
            {
                if (mas_kilk_7[i] > 1)
                { i_len++; }
            }

            mas7 = new string[i_len];
            chast_7 = new double[i_len];
            mas_kilk7 = new int[i_len];
            grid2_0(nowy_mas_7, mas_kilk_7, chast7, mas7, chast_7, mas_kilk7);
            grid2_0_v(dataGridView12, mas7, mas_kilk7, chast_7);

            #endregion

            #region TF-IDF kat1

            kilk_text = new int[nowy_mas.Length];
            txt1 = richTextBox13.Text.ToLower();
            txt2 = richTextBox14.Text.ToLower();
            txt3 = richTextBox25.Text.ToLower();
            txt4 = richTextBox26.Text.ToLower();
            txt5 = richTextBox27.Text.ToLower();
            txt6 = richTextBox28.Text.ToLower();

            text_new = "";
            mas_text2 = t.txt1(txt1, mas, text_new);
            text_new = "";
            mas_text3 = t.txt1(txt2, mas, text_new);
            text_new = "";
            mas_text4 = t.txt1(txt3, mas, text_new);
            text_new = "";
            mas_text5 = t.txt1(txt4, mas, text_new);
            text_new = "";
            mas_text6 = t.txt1(txt5, mas, text_new);
            text_new = "";
            mas_text7 = t.txt1(txt6, mas, text_new);
            text_new = "";

            idf1 = new double[nowy_mas.Length];
            t.kilkist_textiv(nowy_mas, mas_text2, mas_text3,mas_text4,mas_text5, mas_text6,mas_text7, kilk_text);

            tf_idf1 = new double[nowy_mas.Length];
            Met.tf_idf(nowy_mas, kilk_text, idf1);

            #endregion
            #region TF-IDF kat2

            kilk_text = new int[nowy_mas_2.Length];
            idf2 = new double[nowy_mas_2.Length];
            t.kilkist_textiv(nowy_mas_2, mas_text2, mas_text3,mas_text4,mas_text5, mas_text6,mas_text7, kilk_text);

            tf_idf2 = new double[nowy_mas_2.Length];
            Met.tf_idf(nowy_mas_2, kilk_text, idf2);



            #endregion
            #region TF-IDF kat3

            kilk_text = new int[nowy_mas_3.Length];
            idf3 = new double[nowy_mas_3.Length];
            t.kilkist_textiv(nowy_mas_3, mas_text2, mas_text3, mas_text4, mas_text5, mas_text6, mas_text7, kilk_text);

            tf_idf3 = new double[nowy_mas_3.Length];
            Met.tf_idf(nowy_mas_3, kilk_text, idf3);



            #endregion
            #region TF-IDF kat4

            kilk_text = new int[nowy_mas_4.Length];
            idf4 = new double[nowy_mas_4.Length];
            t.kilkist_textiv(nowy_mas_4, mas_text2, mas_text3, mas_text4, mas_text5, mas_text6, mas_text7, kilk_text);

            tf_idf4 = new double[nowy_mas_4.Length];
            Met.tf_idf(nowy_mas_4, kilk_text, idf4);



            #endregion
            #region TF-IDF kat5

            kilk_text = new int[nowy_mas_5.Length];
            idf5 = new double[nowy_mas_5.Length];
            t.kilkist_textiv(nowy_mas_5, mas_text2, mas_text3, mas_text4, mas_text5, mas_text6, mas_text7, kilk_text);

            tf_idf5 = new double[nowy_mas_5.Length];
            Met.tf_idf(nowy_mas_5, kilk_text, idf5);



            #endregion
            #region TF-IDF kat6

            kilk_text = new int[nowy_mas_6.Length];
            idf6 = new double[nowy_mas_6.Length];
            t.kilkist_textiv(nowy_mas_6, mas_text2, mas_text3, mas_text4, mas_text5, mas_text6, mas_text7, kilk_text);

            tf_idf6 = new double[nowy_mas_6.Length];
            Met.tf_idf(nowy_mas_6, kilk_text, idf6);



            #endregion
            #region TF-IDF kat7

            kilk_text = new int[nowy_mas_7.Length];
            idf7 = new double[nowy_mas_7.Length];
            t.kilkist_textiv(nowy_mas_7, mas_text2, mas_text3, mas_text4, mas_text5, mas_text6, mas_text7, kilk_text);

            tf_idf7 = new double[nowy_mas_7.Length];
            Met.tf_idf(nowy_mas_7, kilk_text, idf7);



            #endregion

            mas_ob_1 = grid(nowy_mas, chast, idf1, tf_idf1);
            mas_ob_2 = grid(nowy_mas_2, chast2, idf2, tf_idf2);
            mas_ob_3 = grid(nowy_mas_3, chast3, idf3, tf_idf3);
            mas_ob_4 = grid(nowy_mas_4, chast4, idf4, tf_idf4);
            mas_ob_5 = grid(nowy_mas_5, chast5, idf5, tf_idf5);
            mas_ob_6 = grid(nowy_mas_6, chast6, idf6, tf_idf6);
            mas_ob_7 = grid(nowy_mas_7, chast7, idf7, tf_idf7);
         
        }


        public void news(string text,string [] mas_text,string text_new)
        {
           
            text_new = "";

            test_text.Clear();

            k = 0;
            for (int i = 0; i < mas_text.Length; i++)
            {
                test_text.Add(mas_text[i]);
                mas_text[i] = "";
            }
            for (int i = 0; i < test_text.Count; i++)
            {
                if (test_text[i] == "\n" || test_text[i] == " " || test_text[i] == "" || string.IsNullOrEmpty(test_text[i]))
                {
                    test_text.Remove(test_text[i]);
                }
                else
                {
                    mas_text[k] = test_text[i];
                    k++;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
             text = richTextBox15.Text.ToLower();

             mas_text = t.txt1(text, mas, text_new);
             news(text, mas_text,text_new);
           
            int[] mas_kilk_test = new int[mas_text.Length];
            string[] mas_slova = new string[mas_text.Length];

            mas_slova[0] = mas_text[0];
            zagal_kilk = 0;
           
            nowy_mas_test = t.mas(mas_text, mas_slova, mas_kilk_test);
            dataGridView6.RowCount = nowy_mas_test.Length;
            dataGridView8.RowCount = nowy_mas_test.Length+1;
            dataGridView9.RowCount = 7;
            double[] znach = new double[nowy_mas_test.Length];
            double[] znach_2 = new double[nowy_mas_test.Length];
            int z = 1;
            for (int i = 0; i < nowy_mas_test.Length; i++)
            {
                dataGridView6.Rows[i].Cells[0].Value = nowy_mas_test[i];
                dataGridView6.Rows[i].Cells[1].Value = mas_kilk_test[i];
                dataGridView8.Rows[i].Cells[0].Value = nowy_mas_test[i];
                z = 1;
                Kategor.kat_novyny(dataGridView8,len_for_kat,mas_ob_1, mas_kilk_test, i, tf_idf1, z, nowy_mas_test);
                z = 2;
                Kategor.kat_novyny(dataGridView8, len_for_kat, mas_ob_2, mas_kilk_test, i, tf_idf2, z, nowy_mas_test);
                z = 3;
                Kategor.kat_novyny(dataGridView8, len_for_kat, mas_ob_3, mas_kilk_test, i, tf_idf3, z, nowy_mas_test);
                z = 4;
                Kategor.kat_novyny(dataGridView8, len_for_kat, mas_ob_4, mas_kilk_test, i, tf_idf4, z, nowy_mas_test);
                z = 5;
                Kategor.kat_novyny(dataGridView8, len_for_kat, mas_ob_5, mas_kilk_test, i, tf_idf5, z, nowy_mas_test);
                z = 6;
                Kategor.kat_novyny(dataGridView8, len_for_kat, mas_ob_6, mas_kilk_test, i, tf_idf6, z, nowy_mas_test);
                z = 7;
                Kategor.kat_novyny(dataGridView8, len_for_kat, mas_ob_7, mas_kilk_test, i, tf_idf7, z, nowy_mas_test);
                
                    zagal_kilk += mas_kilk_test[i];
            }
            dataGridView8.Rows[nowy_mas_test.Length].Cells[0].Value = "Сума";
            double s = 0;
            int q = 1;

            for (int i = 0; i < 7; i++)
            {
                Count.Summ(dataGridView8, s, nowy_mas_test, q);
                s = 0; q++;
            }
         

            dataGridView8.Rows[nowy_mas_test.Length].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
           
            dataGridView9.Rows[0].Cells[0].Value = Column6.HeaderText;
            dataGridView9.Rows[1].Cells[0].Value = Column7.HeaderText;
            dataGridView9.Rows[2].Cells[0].Value = Column8.HeaderText;
            dataGridView9.Rows[3].Cells[0].Value = Column9.HeaderText;
            dataGridView9.Rows[4].Cells[0].Value = Column10.HeaderText;
            dataGridView9.Rows[5].Cells[0].Value = Column11.HeaderText;
            dataGridView9.Rows[6].Cells[0].Value = Column12.HeaderText;

           

            for (int i = 0; i < 7;i++ )
            {
                dataGridView9.Rows[i].Cells[1].Value = dataGridView8.Rows[nowy_mas_test.Length].Cells[i+1].Value;
            }
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) obm = 1;
            else
            obm = 0;
            if (number_vkl == 0)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas.Length;
                grid_vyvod(mas_ob_1, len_gr);
            }

            if (number_vkl == 1)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_2.Length;
                grid_vyvod(mas_ob_2, len_gr);
            }

            if (number_vkl == 2)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_3.Length;
                grid_vyvod(mas_ob_3, len_gr);
            }
            if (number_vkl == 3)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_4.Length;
                grid_vyvod(mas_ob_4, len_gr);
            }
            if (number_vkl == 4)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_5.Length;
                grid_vyvod(mas_ob_5, len_gr);
            }
            if (number_vkl == 5)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_6.Length;
                grid_vyvod(mas_ob_6, len_gr);
            }
            if (number_vkl == 6)
            {
                if (obm == 1) len_gr = 30; else len_gr = nowy_mas_7.Length;
                grid_vyvod(mas_ob_7, len_gr);
            }


        }
        public void grid2_0( string[] nowy_mas, int[] mas_kilk, double[] chast, string[] mas1, double[] chast_, int[] mas_kilk_)
        {
            for (int i = 0; i < nowy_mas.Length; i++)
            {
                if (mas_kilk[i] > 1)
                {
                    mas1[len] = nowy_mas[i];
                    chast_[len] = chast[i];
                    mas_kilk_[len] = mas_kilk[i];
                    len++;
                }
            }
            len = 0;
           
        }

        public void grid2_0_v(DataGridView dataGridView1,string[] mas1,int [] mas_kilk_,double[]chast_)
        {
            dataGridView1.RowCount = mas1.Length;

            for (int i = 0; i < mas1.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = mas1[i];
                dataGridView1.Rows[i].Cells[1].Value = mas_kilk_[i];
                dataGridView1.Rows[i].Cells[2].Value = chast_[i];
            }
        }
        public void grid_0(DataGridView dataGridView1, string[] nowy_mas, int[] mas_kilk, double[] chast)
        {
           
            dataGridView1.RowCount = nowy_mas.Length;

            for (int i = 0; i < nowy_mas.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = nowy_mas[i];
                dataGridView1.Rows[i].Cells[1].Value = mas_kilk[i];
                dataGridView1.Rows[i].Cells[2].Value = chast[i];
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                grid2_0_v(dataGridView1,mas1,mas_kilk_,chast_);
                grid2_0_v(dataGridView2, mas2, mas_kilk2, chast_2);
                grid2_0_v(dataGridView5, mas3, mas_kilk3, chast_3);
                grid2_0_v(dataGridView7, mas4, mas_kilk4, chast_4);
                grid2_0_v(dataGridView10, mas5, mas_kilk5, chast_5);
                grid2_0_v(dataGridView11, mas6, mas_kilk6, chast_6);
                grid2_0_v(dataGridView12, mas7, mas_kilk7, chast_7);
            }
            else
            {
                grid_0(dataGridView1, nowy_mas, mas_kilk, chast);
                grid_0(dataGridView2, nowy_mas_2, mas_kilk_2, chast2);
                grid_0(dataGridView5, nowy_mas_3, mas_kilk_3, chast3);
                grid_0(dataGridView7, nowy_mas_4, mas_kilk_4, chast4);
                grid_0(dataGridView10, nowy_mas_5, mas_kilk_5, chast5);
                grid_0(dataGridView11, nowy_mas_6, mas_kilk_6, chast6);
                grid_0(dataGridView12, nowy_mas_7, mas_kilk_7, chast7);
            }
        }

    }
}
