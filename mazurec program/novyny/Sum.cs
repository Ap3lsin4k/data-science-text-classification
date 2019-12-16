using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace novyny
{
    class Sum
    {
        public void Summ(DataGridView dataGridView8, double s, string[] nowy_mas_test, int k)
        {
            for (int i = 0; i < nowy_mas_test.Length; i++)
            {
                s += Convert.ToDouble(dataGridView8.Rows[i].Cells[k].Value);
            }
            dataGridView8.Rows[nowy_mas_test.Length].Cells[k].Value = s;

        }
      
    }
}
