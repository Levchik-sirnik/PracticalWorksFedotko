using System;
using System.Net.Http.Headers;

namespace Practice17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 1, 1, 1 },
                new int[] { 2, 2, 2, 2 },
                new int[] { 3, 3, 3, 3 }
            };

            Console.WriteLine("Original array:");
            PrintArr(arr);


            // task 1
            int[] endRow = {9, 9, 9, 9 };
            arr = AddRowAtEnd(arr, endRow);
            PrintArr(arr);


            // task 2
            int[] startRow = { 0, 0, 0, 0 };
            arr = AddRowAtStart(arr, startRow);
            PrintArr(arr);


            // task 3
            int[] middleRow = { 5, 5, 5, 5 };
            arr = AddRowAtPosition(arr, middleRow, 2);
            PrintArr(arr);


            // task 4
            arr = RemoveRowAtPosition(arr, 3);
            PrintArr(arr);

        }

        static int[][] AddRowAtEnd(int[][] oldArr, int[] newRow)
        {
            int[][] newArr = new int[oldArr.Length + 1][];

            for (int i = 0; i < oldArr.Length; i++)
            {
                newArr[i] = oldArr[i];
            }

            newArr[newArr.Length - 1] = newRow;
            return newArr;
        }


        static int[][] AddRowAtStart(int[][] oldArr, int[] newRow)
        {
            int[][] newArr = new int[oldArr.Length + 1][];

            newArr[0] = newRow;

            for (int i = 0; i < oldArr.Length; i++)
            {
                newArr[i + 1] = oldArr[i];
            }

            return newArr;
        }


        static int[][] AddRowAtPosition(int[][] oldArr, int[] newRow, int index)
        {
            if (index < 0 || index > oldArr.Length) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            int[][] newArr = new int[oldArr.Length + 1][];

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < index) newArr[i] = oldArr[i];
                else if (i == index) newArr[i] = newRow;
                else newArr[i] = oldArr[i - 1];
            }

            return newArr;
        }


        static int[][] RemoveRowAtPosition(int[][] oldArr, int index)
        {
            if (index < 0 || index > oldArr.Length) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            int[][] newArr = new int[oldArr.Length - 1][];

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < index) newArr[i] = oldArr[i];
                else newArr[i] = oldArr[i + 1];
            }

            return newArr;
        }


        static void PrintArr(int[][] arr)
        {
            foreach(var row in arr)
            {
                Console.WriteLine(string.Join("\t", row));
            }
            Console.WriteLine();
        }

    }
}
