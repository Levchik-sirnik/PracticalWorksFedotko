using System;

namespace Practice5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1
            Console.WriteLine("Available colors: Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, " +
                "Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White");

            Console.Write("Enter background color from the list above: ");
            string bgInput = Console.ReadLine()!;

            Console.Write("Enter foreground color from the list above: ");
            string fgInput = Console.ReadLine()!;

            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), bgInput, true);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), fgInput, true);
            Console.Clear();
            Console.WriteLine($"Background color set to {bgInput}, foreground color set to {fgInput}.");


            // task 2
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);

            Console.Write("Enter degree from 0 to 7: ");
            int degree = int.Parse(Console.ReadLine()!);

            if (degree < 0 || degree > 7)
            {
                Console.WriteLine("Degree must be between 0 and 7.");
            }
            else
            {
                int result = (int)Math.Pow(number, degree);
                Console.WriteLine(result);


            }
        }
    }
}
