using System;

namespace Practice12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine(Power(6, 3));
            Console.WriteLine();


            // task 2
            PrintStars(6);
            Console.WriteLine("\n");


            // task 3
            Console.WriteLine(RangeSum(1, 7));
            Console.WriteLine();


            // task 4
            int[] numbers = new int[100];
            Random rand = new Random();

            Console.WriteLine("Исходный массив (первые 20 элементов для примера):");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-50, 51); 
                if (i < 20)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine("... и так далее до 100.");

            int bestIndex = FindMinSum(numbers, 0, 0, -1);

            int finalSum = 0;
            Console.Write($"Минимальная последовательность (начиная с позиции {bestIndex}): ");
            for (int i = bestIndex; i < bestIndex + 10; i++)
            {
                Console.Write(numbers[i] + " ");
                finalSum += numbers[i];
            }

            Console.WriteLine($"\nСумма этой последовательности: {finalSum}\n");


            // task 5
            int[] arr1 = { 5, -3, 12, 8, 2 };
            Console.WriteLine($"Максимум в одномерном массиве: {Max(arr1)}");

            int[,] arr2 = {
            { 1, 4, 3 },
            { 9, 2, 25 },
            { 7, 0, 6 }
            };
            Console.WriteLine($"Максимум в двумерном массиве: {Max(arr2)}");

            int[,,] arr3 = new int[2, 2, 2] {
            { { 1, 2 }, { 3, 4 } },
            { { 5, 8 }, { 42, 7 } }
            };
            Console.WriteLine($"Максимум в трехмерном массиве: {Max(arr3)}");

            int num1 = 15, num2 = 34;
            Console.WriteLine($"Максимум из двух чисел ({num1}, {num2}): {Max(num1, num2)}");

            int n1 = 50, n2 = 105, n3 = 73;
            Console.WriteLine($"Максимум из трёх чисел ({n1}, {n2}, {n3}): {Max(n1, n2, n3)}");

        }

        static double Power(double number, int exp)
        {
            if (exp == 0) return 1;

            if (exp < 0) return 1 / Power(number, -exp);

            return number * Power(number, exp - 1);
        }


        static void PrintStars(int n)
        {
            if (n <= 0) return;

            Console.Write("*");

            PrintStars(n - 1);
        }


        static int RangeSum(int a, int b)
        {
            if (a > b) return 0;

            return a + RangeSum(a + 1, b);
        }


        static int FindMinSum(int[] arr, int index, int minSum, int minIndex)
        {
            if (index > arr.Length - 10) return minIndex;

            int currentSum = 0;
            for (int i = index; i < index + 10; i++) currentSum += arr[i];

            if (index == 0 || currentSum < minSum)
            {
                minSum = currentSum;
                minIndex = index;
            }

            return FindMinSum(arr, index + 1, minSum, minIndex);
        }


        static int Max(int[] arr)
        {
            int max = arr[0];
            foreach (int el in arr)
            {
                if (el > max) max = el;
            }
            return max;
        }

        static int Max(int[,] arr)
        {
            int max = arr[0, 0];
            foreach (int el in arr)
            {
                if (el > max) max = el;
            }
            return max;
        }

        static int Max(int[,,] arr)
        {
            int max = arr[0, 0, 0];
            foreach (int el in arr)
            {
                if (el > max) max = el;
            }
            return max;
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static int Max(int a, int b, int c)
        {
            return Max(Max(a, b), c);
        }
    }
}