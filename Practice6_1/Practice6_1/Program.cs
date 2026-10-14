using System;

namespace Practice6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);

            for (int i = 0; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            // task 2
            Console.Write("Enter the first boundary: ");
            int input1 = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the second boundary: ");
            int input2 = int.Parse(Console.ReadLine()!);

            int start = Math.Min(input1, input2);
            int end = Math.Max(input1, input2);

            Console.WriteLine("\nAll numbers in the range:");
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nEven numbers in the range:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n\nOdd numbers in the range:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n\nMultiples of 7 in the range:");
            for (int i = start; i <= end; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();


            // task 3
            Console.Write("Enter the first boundary: ");
            int input3 = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the second boundary: ");
            int input4 = int.Parse(Console.ReadLine()!);

            int start2 = Math.Min(input3, input4);
            int end2 = Math.Max(input3, input4);

            int sum = 0;
            for (int i = start2; i <= end2; i++)
            {
                sum += i;
            }

            Console.WriteLine($"sum = {sum}");


            // task 4
            int sum2 = 0;
            int num;

            Console.WriteLine("Enter numbers to sum (enter 0 to finish):");

            do
            {
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine()!);
                sum2 += num;
            }
            while (num != 0);
            Console.WriteLine($"sum = {sum2}");
        }
    }
}
