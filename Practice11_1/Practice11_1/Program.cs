using System;

namespace Practice11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            DrawRectangle(7, 3);


            // task 2
            Console.WriteLine(Factorial(5));


            // task 3
            Console.WriteLine(IsPrime(7));


            // task 4
            Console.WriteLine(Cube(5));


            // task 5
            Console.WriteLine(Max(3.5, 2.8));


            // task 6
            Console.WriteLine(IsPositive(-3));
        }


        static void DrawRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n must be non-negative");
            }
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }


        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        static double Cube(double number) { return number * number * number; }

        static double Max(double a, double b) { return a > b ? a : b; }

        static bool IsPositive(int number) { return number > 0; }
    }
}
