namespace Practice3_2
{
    internal class Programm 
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
            double multiplication = num1 * num2;
            Console.WriteLine($"The multiplication of {num1} and {num2} is {multiplication}");
            double average = (num1 + num2) / 2;
            Console.WriteLine($"The average of {num1} and {num2} is {average}");


            // task 2
            Console.Write("Enter number 3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 4: ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 5: ");
            double num5 = Convert.ToDouble(Console.ReadLine());
            double sum2 = num3 + num4 + num5;
            Console.WriteLine($"The sum of {num3}, {num4}, and {num5} is {sum2}");
            double multiplication2 = num3 * num4 * num5;
            Console.WriteLine($"The multiplication of {num3}, {num4}, and {num5} is {multiplication2}");
            double average2 = (num3 + num4 + num5) / 3;
            Console.WriteLine($"The average of {num3}, {num4}, and {num5} is {average2}");


            // task 3
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter discount: ");
            int discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total price: {(price * count) - (price * count * discount / 100)}");


            // task 4
            const int salary = 100;
            const double percent = 0.05;

            Console.Write("Enter count of deals: ");
            int dealsCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total salary: {salary + (dealsCount * percent)}");


            // task 5
            Console.Write("Enter file size (GB): ");
            double gigabytes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter internet connection speed (bps): ");
            double speedBitsPerSec = Convert.ToDouble(Console.ReadLine());

            double totalBits = gigabytes * 1024 * 1024 * 1024 * 8; 
            double totalSeconds = totalBits / speedBitsPerSec;

            int hours = (int)(totalSeconds / 3600);
            int minutes = (int)((totalSeconds % 3600) / 60);
            int seconds = (int)(totalSeconds % 60);

            Console.WriteLine($"Estimated download time: {hours:D2}:{minutes:D2}:{seconds:D2}");


        }
    }
}
