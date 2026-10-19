using System;

namespace Practice8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter width size: ");
            int width = int.Parse(Console.ReadLine()!);
            Console.Write("Enter length size: ");
            int length = int.Parse(Console.ReadLine()!);
            Console.Write("Enter symbol: ");
            char symbol = Console.ReadLine()![0];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


            // task 2
            Console.Write("Enter width size: ");
            int width2 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter length size: ");
            int length2 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter symbol: ");
            char symbol2 = Console.ReadLine()![0];

            for (int i = 0; i < width2; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    if (i == 0 || i == width2 - 1 || j == 0 || j == length2 - 1)
                    {
                        Console.Write(symbol2);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
