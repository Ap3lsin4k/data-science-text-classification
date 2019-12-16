using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novyny
{
    class Text
    {
       
        public string[] txt1(string text, string[] mas, string text_new)
        {
            string[] mas_chys = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\r", "+", "°" };
            int i, j, k = 0;

            for (i = 0; i < text.Length; i++)
            {
                if (Char.IsPunctuation(text[i]))
                {
                    k = 1;
                }
                else
                {
                    for (j = 0; j < mas_chys.Length; j++)
                    {
                        if (Convert.ToString(text[i]) == mas_chys[j])
                        {
                            k = 1;
                            break;
                        }
                    }
                   
                        for (j = 0; j < mas.Length; j++)
                        {

                            if (text[i] == Convert.ToChar(mas[j])) { k = 0; }
                        }
                   
                }  
             
                if (k == 0)
                {
                    text_new += Convert.ToString(text[i]);
                    
                }
                k = 0;
            }

            return text_new.Split(' ');
        }
        public string[] mas(string[] mas_text, string[] mas_slova, int[] mas_kilk)
        {
            int i, j;
            int kilk, zmin = 1, zagal_kilk = 0;
            for (i = 1; i < mas_text.Length; i++)
            {
                kilk = 0;

                for (j = 0; j < mas_text.Length; j++)
                {
                    if (mas_text[i] == mas_slova[j])
                    {
                        kilk++;
                    }
                }
                if (kilk == 0)
                {
                    mas_slova[zmin] = mas_text[i];
                    zmin++;
                }
            }

            kilk = 0;
            for (i = 0; i < mas_slova.Length; i++)
                if (mas_slova[i] != null) kilk++;

            string[] nowy_mas = new string[kilk];

            //перезаписую в новий мaсив всі не нул елементи 
            for (i = 0; i < nowy_mas.Length; i++)
                nowy_mas[i] = mas_slova[i];


            //рахую які елементи повтрюються
            for (i = 0; i < nowy_mas.Length; i++)
            {
                for (j = 0; j < mas_text.Length; j++)
                {
                    if (nowy_mas[i] == mas_text[j])
                        mas_kilk[i]++;
                }
            }
            return nowy_mas;
        }
        public int[] kilkist_textiv(string[] nowy_mas, string[] mas_text2, string[] mas_text3,string[] mas_text4,string[] mas_text5,string[] mas_text6,string[] mas_text7, int[] kilk_text)
        {
            int i, j, k = 0;
            for (i = 0; i < nowy_mas.Length; i++)
            {
                for (j = 0; j < mas_text2.Length; j++)
                {
                    if (nowy_mas[i] == mas_text2[j]) { k = 1; break; }
                    else k = 0;
                }
                if (k == 1) kilk_text[i]++;

                for (j = 0; j < mas_text3.Length; j++)
                {
                    if (nowy_mas[i] == mas_text3[j]) { k = 1; break; }
                    else k = 0;
                }
                if (k == 1) kilk_text[i]++;

                for (j = 0; j < mas_text4.Length; j++)
                {
                    if (nowy_mas[i] == mas_text4[j]) { k = 1; break; }
                    else k = 0;
                }
                if (k == 1) kilk_text[i]++;

                for (j = 0; j < mas_text5.Length; j++)
                {
                    if (nowy_mas[i] == mas_text5[j]) { k = 1; break; }
                    else k = 0;
                }
                if (k == 1) kilk_text[i]++;

                for (j = 0; j < mas_text6.Length; j++)
                {
                    if (nowy_mas[i] == mas_text6[j]) { k = 1; break; }
                    else k = 0;
                }
                if (k == 1) kilk_text[i]++;

                for (j = 0; j < mas_text7.Length; j++)
                {
                    if (nowy_mas[i] == mas_text7[j]) { k = 1; break; }
                    else k = 0;
                }
                if (k == 1) kilk_text[i]++;
            }
            return kilk_text;
        }


    }
}
