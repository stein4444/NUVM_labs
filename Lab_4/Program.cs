using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class BaseLineFunction
    {
        public int aO;
        public int a1;
        public int bO;
        public int b1;
        public int xO { get; set; }
        private bool calc = false;
        public BaseLineFunction()
        {
            aO = 0;
            a1 = 0;
            bO = 0;
            b1 = 0;
            xO = 0;
        }

        public BaseLineFunction(int a0, int A1, int b0, int B1)
        {
            aO = a0;
            a1 = A1;
            bO = b0;
            b1 = B1;
        }

        public void SetCoefficients(int a0, int A1, int b0, int B1)
        {
            this.aO = a0;
            this.a1 = A1;
            this.bO = b0;
            this.b1 = B1;

            if (bO == 0 && b1 == 0)
            {
                Console.WriteLine("b0 та b1 не можуть одночасно дорівнювати 0");
            }
            else calc = true;
        }

        public void Show()
        {
            Console.WriteLine("Коеффіцієнт а0: " + aO);
            Console.WriteLine("Коеффіцієнт а1: " + a1);
            Console.WriteLine("Коеффіцієнт b0: " + bO);
            Console.WriteLine("Коеффіцієнт b1: " + b1);

        }
        public void Calculate()
        {
            if (calc == true)
            {
                float F;
                F = ((a1 * xO) + aO) / ((b1 * xO) + bO);
                Console.WriteLine($"F(x) = {F}");
            }
            else Console.WriteLine("Error please fill b1, b0 correctly");
        }
    }


    class FractionalFunction : BaseLineFunction
    {
        private int a2;
        private int b2;
        private bool calc = false;
        public FractionalFunction()
        {
            a2 = 0;
            b2 = 0;
            xO = 0;
        }
        public FractionalFunction(int a0, int A1, int b0, int B1,int A2, int B2) : base(a0, A1, b0, B1)
        {
            a2 = A2;
            b2 = B2;
        }
        public void SetCoefficients(int a0, int A1, int b0, int B1, int A2, int B2)
        {
            base.SetCoefficients(a0, A1, b0, B1);
            a2 = A2;
            b2 = B2;
            if (b0 == 0 || B1 == 0 && b2 == 0 )
            {
                Console.WriteLine("b0, b1, b2 не можуть одночасно дорівнювати 0");
            }
            else calc = true;
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine("Коеффіцієнт a2: " + a2);
            Console.WriteLine("Коеффіцієнт b2: " + b2);
        }

        public void Calculate()
        {
            if (calc == true)
            {
                double F;
                F = (a2 * Math.Pow(xO, 2) + a1 * xO + aO) / (b2 * Math.Pow(xO, 2) + b1 * xO + bO);
                Console.WriteLine($"F(x) = {(float)F}");
            }
            else Console.WriteLine("Error please fill b1, b0, b2 correctly");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //    BaseLineFunction bs = new BaseLineFunction();
            //    bs.SetCoefficients(1,4,2,3);
            //    bs.Show();
            //    bs.xO = 3;
            //    bs.Calculate();

            FractionalFunction fractionalFunction = new FractionalFunction();
            fractionalFunction.SetCoefficients(1, 3, 4, 5, 6, 7);
            fractionalFunction.Show();
            fractionalFunction.xO = 2;
            fractionalFunction.Calculate();
        }

    }
}
