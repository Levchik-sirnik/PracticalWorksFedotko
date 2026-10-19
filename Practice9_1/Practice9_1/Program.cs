using System.Linq;

namespace Practice9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[] arr = { 3, 0, 1, 0, 0, 5, 0, 9 };

            int writeIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[writeIndex] = arr[i];
                    writeIndex++;
                }
            }

            while (writeIndex < arr.Length)
            {
                arr[writeIndex] = -1;
                writeIndex++;
            }

            Console.WriteLine(string.Join(", ", arr));


            // task 2
            int[] arr1 = new int[5] { 0, -23, 2, 56, -2 };
            int[] arr2 = new int[5] { 63, 0, 85, -345, 10 };
            int[] arr3 = new int[10];

            int[] result = arr1.Concat(arr2).
                OrderBy(x => x > 0 ? 0 : (x == 0 ? 1 : 2))
                .ToArray();

            Console.WriteLine(string.Join(", ", result));


        }
    }
}
