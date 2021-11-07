using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = getCoords(3.4, 6.7, 1.3, 2.4);
            Console.WriteLine(result);
        }

        public static double getCoords(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
