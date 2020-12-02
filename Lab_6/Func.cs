using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public abstract class Function
    {
        public int aO;
        public int a1;
        public int bO;
        public int b1;
        public int xO { get; set; }
        public bool calc = false;
        public Function() { }
        public Function(int a0, int A1, int b0, int B1, bool act)
        {
            aO = a0;
            a1 = A1;
            bO = b0;
            b1 = B1;
            calc = act;
        }
        public abstract void SetCoefficients(int a0, int A1, int b0, int B1, int A2, int B2);
        public abstract void Show();

        public abstract void Calculate();
       
    }
}
