using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novyny
{
    class Methods
    {
        ///TF
        public double[] tf(string[] nowy_mas, int[] mas_kilk, int zagal_kilk, double[] chast)
        {

            for (int i = 0; i < nowy_mas.Length; i++)
            {
                chast[i] = Convert.ToDouble(mas_kilk[i]) / zagal_kilk;
            }
            return chast;
        }
        ///TF-IDF
        public double[] tf_idf(string[] nowy_mas, int[] kilk_text, double[] idf)
        {

            for (int i = 0; i < nowy_mas.Length; i++)
            {
                idf[i] = Math.Log((7 / (kilk_text[i] + 1)));
              //idf[i] = Math.Log((3- kilk_text[i]+0.5) / (kilk_text[i] + 1+0.5));

            }
            return idf;
        }
        public double[] de(string[] nowy_mas, string[] mas_text, double[] A, double[] dyspers, int[] mas_kilk)
        {
            for (int i = 0; i < nowy_mas.Length; i++)
            {
                for (int j = 0; j < mas_text.Length; j++)
                {
                    if (nowy_mas[i] == mas_text[j])
                        A[i] = A[i] + (j - A[i]);
                }
                dyspers[i] = Math.Sqrt(
                        (
                            Math.Pow(A[i], 2) / mas_kilk[i] 
                            - 
                            Math.Pow(A[i] / mas_kilk[i], 2)
                            )
                        / 
                        (A[i] / mas_kilk[i])
                    );
                //sqrt(A**2/kil -  (A/kil)**2 //
            }
            return dyspers;
        }
    }
}
