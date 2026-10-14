using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 2, 1, 3, 34, 21, 56, 3, 8 };
            //Console.WriteLine(String.Join(", ", arr));
            //BubbleSort(arr);
            //Console.WriteLine(String.Join(", ", arr));


            int[] arr = new int[5];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100); 
            }
            Console.WriteLine(String.Join(", ", arr));

            int temp = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                
            }
            Console.WriteLine(String.Join(", ", arr));
            
        }

        //static void BubbleSort(int[] arr)
        //{
        //    bool swapped;
        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        swapped = false;
        //        for (int j = 0; j < arr.Length - 1 - i; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;

        //                swapped = true;
        //            }
        //        }
        //        if (!swapped) break;
        //    }
        //}
    }
}