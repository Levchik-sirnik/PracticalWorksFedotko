using System;

namespace Practice12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine(Power(6, 3));


            // task 2
            PrintStars(6);
            Console.WriteLine();


            // task 3
            Console.WriteLine(RangeSum(1, 7));


            // task 4
            int[] numbers = new int[100];
            Random rand = new Random();

            Console.WriteLine("Исходный массив (первые 20 элементов для примера):");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-50, 51); // числа от -50 до 50
                if (i < 20)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine("... и так далее до 100.\n");

            // Запускаем рекурсию с начального (0) индекса
            // В качестве начальной минимальной суммы передаем 0, а индекс -1
            int bestIndex = FindMinSum(numbers, 0, 0, -1);

            // Считаем сумму найденной последовательности для вывода результата
            int finalSum = 0;
            Console.Write($"Минимальная последовательность (начиная с позиции {bestIndex}): ");
            for (int i = bestIndex; i < bestIndex + 10; i++)
            {
                Console.Write(numbers[i] + " ");
                finalSum += numbers[i];
            }

            Console.WriteLine($"\nСумма этой последовательности: {finalSum}");
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
    }
}