using System;

namespace OffsetTwoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5]
            {
                {1, 2, 3, 4, 5 },
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            Console.Write("Choose an option with arrows:");
            ConsoleKey key = Console.ReadKey().Key;
            OffsetArray(arr, key);
            Console.WriteLine(2 % 3);
        }

        static void OffsetArray(int[,] arr, ConsoleKey key)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[,] newArr = new int[rows, cols];
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            newArr[i, j] = arr[(i + 1) % rows, j];
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            newArr[i, j] = arr[(i - 1 + rows) % rows, j];
                        }
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            newArr[i, j] = arr[i, (j + 1) % cols];
                        }
                    }
                    break;
                case ConsoleKey.RightArrow:
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            newArr[i, j] = arr[i, (j - 1 + cols) % cols];
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid key pressed.");
                    return;
            }
            Console.WriteLine("Offset Array:");
            PrintArray(newArr);
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
