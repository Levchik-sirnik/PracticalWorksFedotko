using System;

namespace Practice8_2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // task 1
            double[] profit = new double[6];

            for (int i = 0; i < profit.Length; i++)
            {
                Console.Write($"Enter the profit for month {i + 1}: ");
                profit[i] = Convert.ToDouble(Console.ReadLine());
            }

            double totalProfit = 0;

            for (int i = 0; i < profit.Length; i++)
            {
                totalProfit += profit[i];
            }

            Console.WriteLine($"Total profit for the half of year: {totalProfit}");


            // task 2
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = arr.Length; i > 0; i--)
            {
                Console.WriteLine(arr[i - 1]);
            }


            // task 3
            int[] sides = new int[5];

            for (int i = 0; i < sides.Length; i++)
            {
                Console.Write($"Enter the length of side {i + 1}: ");
                sides[i] = Convert.ToInt32(Console.ReadLine());
            }

            int perimeter = 0;

            for (int i = 0; i < sides.Length; i++)
            {
                perimeter += sides[i];
            }

            Console.WriteLine($"The perimeter of the polygon is: {perimeter}");


            // task 4
            double[] profit12 = new double[12];

            for (int i = 0; i < profit12.Length; i++)
            {
                Console.Write($"Enter the profit for month {i + 1}: ");
                profit12[i] = Convert.ToDouble(Console.ReadLine());
            }

            double maxProfit = profit12.Max();
            double minProfit = profit12.Min();
            Console.WriteLine($"Max profit: {maxProfit}");
            Console.WriteLine($"Min profit: {minProfit}");
        }
    }
}
