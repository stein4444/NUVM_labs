using System;
using System.Drawing;

namespace Lab_3
{
    public class Quadrangle
    {
        private Point a { get; set; }
        private Point b { get; set; }
        private Point c { get; set; }
        private Point d { get; set; }
        public double P { get; set; }

        public Quadrangle(Point A, Point B, Point C, Point D)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
        }
        public void Perimetr()
        {
            double AD = 0, AB = 0, BC = 0, CD = 0;

            //присвоение переменным возрощаемое значение
            AB = calc(a, b);
            BC = calc(b, c);
            CD = calc(c, d);
            AD = calc(a, d);
            P = AB + BC + CD + AD;
            Console.WriteLine($"Периметр прямокутника: {(float)P} умовних одиниць");
        }

        // функция которая возвращает длину между точками 
        private double calc(Point a, Point b)
        {
            double distX = b.X - a.X;
            double distY = b.Y - a.Y;
            //возрощаемое значение
            return Math.Sqrt(distX * distX + distY * distY);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region points1
            Point a = new Point(4, 4);
            Point b = new Point(1, 0);
            Point c = new Point(-5, 10);
            Point d = new Point(-2, -10);
            #endregion
            #region points2
            Point a1 = new Point(-4, 4);
            Point b1 = new Point(8, 10);
            Point c1 = new Point(5, -10);
            Point d1 = new Point(2, -2);
            #endregion
            #region points3
            Point a2 = new Point(5, 1);
            Point b2 = new Point(8, 2);
            Point c2 = new Point(3, -6);
            Point d2 = new Point(-5, -1);
            #endregion
            #region fillData
            Quadrangle quadrangle = new Quadrangle(a, b, c, d);
            Quadrangle quadrangle1 = new Quadrangle(a1, b1, c1, d1);
            Quadrangle quadrangle2 = new Quadrangle(a2, b2, c2, d2);
            quadrangle.Perimetr();
            quadrangle1.Perimetr();
            quadrangle2.Perimetr();
            #endregion
            Quadrangle[] qd = { quadrangle, quadrangle1, quadrangle2 };
            double[] arr = new double[qd.Length];
            double max = arr[0];

            for (int j = 0; j < qd.Length; j++)
                arr[j] = qd[j].P;
               for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            
            }
            Console.WriteLine($"Найбільший периметр: {(float)max} ");

        }
    }
}
