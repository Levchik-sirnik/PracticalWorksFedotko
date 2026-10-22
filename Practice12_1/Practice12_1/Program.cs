using System;
using System.Net.Http.Headers;

namespace Practice12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[] arr = { 5, 3, 67, 5, 66, 56, 89, 2, -4, -2 };
            Console.WriteLine("Original array: " + String.Join(" ", arr));
            SortArray(arr, arr.Length, true);
            Console.WriteLine("Sorted array: " + String.Join(" ", arr));
            Console.WriteLine();


            // task 2
            int[] arr2 = { 4, 1, 8, 3, 9, 2, 7, 5, 0, 6 };
            Console.WriteLine("Original array: " + String.Join(" ", arr2));
            SortHalvesInsertion(arr2);
            Console.WriteLine("Sorted array" + String.Join(" ", arr2));
            Console.WriteLine();


            // task 3
            int[] arr3 = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr3.Length; i++) arr3[i] = rand.Next(-20, 21);
            Console.WriteLine("Original array: " + String.Join(" ", arr3));

            SortBetweenNegativeBounds(arr3);
            Console.WriteLine("SOrted array: " + String.Join(" ", arr3));
        }


        static void SortArray(int[] arr, int n, bool desc = false)
        {
            if (arr is null || n <= 1) return;
            
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    bool shouldSwap = desc ? (arr[j] < arr[j + 1]) : (arr[j] > arr[j + 1]);
                    if (shouldSwap) (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }


        static void SortHalvesInsertion(int[] arr)
        {
            if (arr is null || arr.Length <= 1) return;

            int midIndex = arr.Length / 2;

            for (int i = 0; i < midIndex; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            for (int i = midIndex; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }


        static void SortBetweenNegativeBounds(int[] arr)
        {
            if (arr is null || arr.Length <= 2) return;

            int firstNeg = -1;
            int lastNeg = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    firstNeg = i;
                    break;
                }
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    lastNeg = i;
                    break;
                }
            }

            if (firstNeg == -1 || lastNeg == -1 || lastNeg - firstNeg <= 1)
            {
                Console.WriteLine("Sort doesn`t need");
                return;
            }

            Console.WriteLine($"Left minus on position {firstNeg} (meaning: {arr[firstNeg]})");
            Console.WriteLine($"Right minus on position {lastNeg} (meaning: {arr[lastNeg]})");

            int startIndex = firstNeg + 1;
            int length = lastNeg - firstNeg - 1;

            Array.Sort(arr, startIndex, length);
        }
    }
}
