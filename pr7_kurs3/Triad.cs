using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_kurs3
{
    internal class Triad
    {

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public void SetParams(int a, int b, int c)
        {
            A = a; B = b; C = c;
        }
        public void SetParamsPlus(int value)
        {
            A += value; B += value; C += value;
        }
        public static Triad operator ++(Triad numbers)
        {
            
        }

    }
}
