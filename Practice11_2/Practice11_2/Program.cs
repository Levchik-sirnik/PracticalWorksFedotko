using System;

namespace Practice11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[] array = { 12, 5, 3, 19, 2, 8, 11, 4 };
            Console.WriteLine("Original array: " + string.Join(", ", array));
            FindMinMax(array);
            Console.WriteLine();


            // task 2
            int[] array2 = { 12, 5, 3, 19, 2, 8, 11, 4 };
            Console.WriteLine("Original array: " + string.Join(", ", array2));
            ReverseArray(array2);
            Console.WriteLine("Reversed array: " + string.Join(", ", array2));
            Console.WriteLine();


            // task 3
            int[] array3 = { 12, 5, 3, 19, 2, 8, 11, 4 };
            Console.WriteLine("Original array: " + string.Join(", ", array3));
            int primeCount = CountPrimes(array3);
            Console.WriteLine($"Number of prime numbers: {primeCount}");
        }


        static void FindMinMax(int[] arr)
        {
            if (arr.Length == 0 || arr == null)
            {
                Console.WriteLine("Array is empty or null.");
                return;
            }

            int minVal = arr[0];
            int minIndex = 0;
            int maxVal = arr[0];
            int maxIndex = 0;


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minVal)
                {
                    minVal = arr[i];
                    minIndex = i;
                }
                if (arr[i] > maxVal)
                {
                    maxVal = arr[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Minimum value: {minVal} at index {minIndex}");
            Console.WriteLine($"Maximum value: {maxVal} at index {maxIndex}");
        }


        static void ReverseArray(int[] arr)
        {
            if (arr.Length == 0 || arr == null)
            {
                Console.WriteLine("Array is empty or null.");
                return;
            }
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
        }


        static int CountPrimes(int[] arr)
        {
            if (arr.Length == 0 || arr == null)
            {
                Console.WriteLine("Array is empty or null.");
                return 0;
            }
            int primeCount = 0;
            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    primeCount++;
                }
            }
            return primeCount;
        }


        static bool IsPrime(int num) 
        {
            if (num <= 1) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
