using System.Drawing;
using System;
namespace Lab_2
{
    public class Quadrangle
    {
        private Point a { get; set; }
        private Point b { get; set; }
        private Point c { get; set; }
        private Point d { get; set; }

        public Quadrangle(Point A, Point B, Point C, Point D)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
        }
        public void Perimetr()
        {
            double P = 0;
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
            Point a = new Point(4,4);
            Point b =  new Point(1, 0); 
            Point c =  new Point(-5, 10);
            Point d = new Point(-2, -10);
            Quadrangle quadrangle = new Quadrangle(a, b, c, d);
            quadrangle.Perimetr();

    }
    }
}
