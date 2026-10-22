using System;

namespace Practice10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[,] numbers = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            Console.WriteLine("Array:");
            PrintArray(numbers);

            int sum = 0;
            int avg = 0;
            int min = 0;
            int max = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sum += numbers[i, j];
                    if (i == 0 && j == 0)
                    {
                        min = numbers[i, j];
                        max = numbers[i, j];
                    }
                    else
                    {
                        if (numbers[i, j] < min)
                        {
                            min = numbers[i, j];
                        }
                        if (numbers[i, j] > max)
                        {
                            max = numbers[i, j];
                        }
                    }
                }
            }
            avg = sum / (numbers.GetLength(0) * numbers.GetLength(1));
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", avg);
            Console.WriteLine("Minimum: {0}", min);
            Console.WriteLine("Maximum: {0}", max);


            // task 2
            int[,] matrix = {
                { 3, 5, 6, 7 },
                { 12, 1, 1, 1 },
                { 0, 7, 12, 1 }
            };
            SumArray(matrix);


            // task 3
            Random rand = new Random();

            int[,] array1 = new int[5, 10];
            int[,] array2 = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array1[i, j] = rand.Next(0, 51); 
                }
            }

            Console.WriteLine("Первый массив (5х10):");
            PrintArray(array1);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2[i, j] = array1[i, j * 2] + array1[i, j * 2 + 1];                }
            }

            Console.WriteLine("Второй массив (5х5):");
            PrintArray(array2);
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void SumArray(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int[] colSums = new int[cols];
            int grandTotal = 0;

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                    rowSum += arr[i, j];
                    colSums[j] += arr[i, j];
                }
                Console.WriteLine($"| {rowSum}");
                grandTotal += rowSum;
            }

            Console.WriteLine(new string('-', cols * 3 + 5));

            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{colSums[j]} ");
            }
            Console.WriteLine($"| {grandTotal}");
        }
    }
}
