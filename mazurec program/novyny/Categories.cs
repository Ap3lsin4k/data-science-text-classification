using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novyny
{
    class Categories
    {
        //запис в категорії новини
        public void kat_novyny(DataGridView dataGridView8, int len_for_kat, string[,] mas_ob, int[] mas_kilk_test, int i, double[] tf_idf1, int z, string[] nowy_mas_test)
        {
            for (int j = 0; j < len_for_kat; j++)
            {
                if (mas_ob[j, 0] == nowy_mas_test[i])
                {
                    dataGridView8.Rows[i].Cells[z].Value = mas_kilk_test[i] * Convert.ToDouble(mas_ob[j, 3]);
                    break;
                }
                else dataGridView8.Rows[i].Cells[z].Value = 0;
            }
        }
    }
}
