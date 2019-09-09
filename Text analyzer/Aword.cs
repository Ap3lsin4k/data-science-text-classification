using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer
{
    class Aword
    {
//        public string word;
        public int k, n;
        List<int> A = new List<int>();

        public Aword(int n)
        {
            //if (A.ContainsKey(word))
            //    this.A[word].Add(n);
            /*else {
                A[word] = new List<int>();
                this.A[word].Add(n);//TODO clean up
            }*/
            A.Add(n);
                
        }

        void addAword(int n)
        {

            A.Add(n)
           /* 
            if (A.ContainsKey(word))
                this.A[word].Add(n);
            else
            {
                A[word] = new List<int>();
                this.A[word].Add(n);//TODO clean up
            }*/
        }
    }
}
