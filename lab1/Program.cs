using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double task13_1 = Task1.getCoords(3.4, 6.7, 1.3, 2.4);
            Console.WriteLine("13.1 result is - " + task13_1);

            double task13_2 = Task2.sumFactorials(3);
            Console.WriteLine("13.2 result is - " + task13_2);

            double task13_3 = Task3.calculateSeriesExpansion(2.5, 6.4);
            Console.WriteLine("13.3 result is - " + task13_3);
        }
    }

    class Task1
    {
        public static double getCoords(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }

    class Task2
    {
        public static double sumFactorials(int n)
        {
            double sum = 0;
            double prod = 1;

            for (int i = 1; i <= n; i++)
            {
                prod *= i;
                sum += prod;
            }

            return sum;
        }
    }

    class Task3
    {
        public static double Factorial(int N)
        {
            double result = 1;
            for (int i = 1; i < N; i++)
            {
                result *= i;
            }

            return result;
        }

        public static double calculateSeriesExpansion(double epsilon, double x)
        {
            double sum = 0;
            double numerator = x;
            double coefNumerator = -x * x;
            double lastSummand;

            int n = 1;

            do
            {
                lastSummand = numerator / Factorial(n);

                sum += lastSummand;
                numerator *= coefNumerator;
                n += 2;
            }
            while (Math.Abs(lastSummand) > epsilon);

            return sum;
        }
    }
}
