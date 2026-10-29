using System;

namespace Practice13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[] array = { 3, 5, 8, 12, 19, 24, 34, 45, 50, 61, 72 };
            int target = 45; 

            Console.WriteLine($"Массив: {string.Join(", ", array)}");
            Console.WriteLine($"Ищем число: {target}");

            int position = BinarySearchRecursive(array, target, 0, array.Length - 1);

            if (position != -1) Console.WriteLine($"Элемент найден; индекс вхождения: {position}\n");
            else Console.WriteLine("Элемент не найден в массиве.\n");


            // tasks 2, 3, 4

            int[,] arr =
            {
                { 4, 5, 6, 7 },
                { 1, 2, 4, 1 },
                { 4, 5, 6, 9 }
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(arr);

            Console.WriteLine("\nСдвиг вправо на 5:");
            ShiftRight(arr, 5);
            PrintArray(arr);

            Console.WriteLine("\nСдвиг влево на 2:");
            ShiftLeft(arr, 2);
            PrintArray(arr);

            Console.WriteLine("\nСдвиг вниз на 1:");
            ShiftDown(arr, 1);
            PrintArray(arr);
        }

        static int BinarySearchRecursive(int[] arr, int target, int low, int high)
        {
            if (low > high) return -1;

            int mid = low + (high - low) / 2;

            if (arr[mid] == target) return mid;

            if (target < arr[mid]) return BinarySearchRecursive(arr, target, low, mid - 1);

            return BinarySearchRecursive(arr, target, mid + 1, high);
        }


        static void ShiftRight(int[,] array, int shifts)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            shifts %= cols;

            if (shifts < 0) shifts += cols;

            if (shifts == 0) return;

            for (int i = 0; i < rows; i++)
            {
                int last = array[i, cols - 1];

                for (int j = cols - 1; j > 0; j--)
                {
                    array[i, j] = array[i, j - 1];
                }

                array[i, 0] = last;
            }

            ShiftRight(array, shifts - 1);
        }


        static void ShiftLeft(int[,] array, int shifts)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            shifts %= cols;

            if (shifts < 0)
                shifts += cols;

            if (shifts == 0)
                return;

            for (int i = 0; i < rows; i++)
            {
                int first = array[i, 0];

                for (int j = 0; j < cols - 1; j++)
                {
                    array[i, j] = array[i, j + 1];
                }

                array[i, cols - 1] = first;
            }

            ShiftLeft(array, shifts - 1);
        }


        static void ShiftDown(int[,] array, int shifts)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            shifts %= rows;

            if (shifts < 0)
                shifts += rows;

            if (shifts == 0)
                return;

            for (int j = 0; j < cols; j++)
            {
                int last = array[rows - 1, j];

                for (int i = rows - 1; i > 0; i--)
                {
                    array[i, j] = array[i - 1, j];
                }

                array[0, j] = last;
            }

            ShiftDown(array, shifts - 1);
        }


        static void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
