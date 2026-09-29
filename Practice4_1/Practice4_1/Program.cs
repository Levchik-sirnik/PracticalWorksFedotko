namespace Practice4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");


            // task 2
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Min: {Math.Min(num1, num2)}");


            // task 3
            Console.Write("Enter number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 > 0) Console.WriteLine("Positive");
            else if (num3 < 0) Console.WriteLine("Negative");
            else Console.WriteLine("Zero");


            // task 4
            Console.Write("Enter number 1: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            if (num4 == num5) Console.WriteLine("Equal");
            else if (num4 > num5)
                Console.WriteLine($"{num5}, {num4}");
            else
                Console.WriteLine($"{num4}, {num5}");
        }
    }
}
