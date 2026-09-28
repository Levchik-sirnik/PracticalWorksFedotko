using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
                Console.WriteLine("оценка " + (i + 1) + "студента " + arr[i]);
            }
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a = a + arr[i];
            }
            Console.WriteLine("средняя оценка студентов : " + (a / 20.0));
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    b++;
                }
            }
            Console.WriteLine("Количество студентов, получивших оценку 5 : " + b);
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    c++;
                }

            }
            Console.WriteLine("количество студентов, получивших оценку 2 : " + c);
            int d = arr[0];
            int e = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > d)
                {
                    d = arr[i];
                    e = i;
                }
            }
            Console.WriteLine("номер студента, получившего самую высокую оценку : " + (e + 1));



        }


    }

}


