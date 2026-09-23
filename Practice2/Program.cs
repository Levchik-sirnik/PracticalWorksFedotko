using System.ComponentModel.DataAnnotations;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int extraDay = Convert.ToInt32(DateTime.IsLeapYear(year));
            int days = 365 + extraDay;
            Console.WriteLine($"In {year} year = {days} days");

            // task 2
            Console.Write("Enter hryvnias: ");
            uint hryvnias = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter kopecks: ");
            uint kopecks = Convert.ToUInt32(Console.ReadLine());
            if (kopecks < 100) Console.WriteLine($"{hryvnias} грн. {kopecks} коп");
            else
            {
                uint count = kopecks / 100;
                kopecks -= count * 100;
                hryvnias += count;
                Console.WriteLine($"{hryvnias} грн. {kopecks} коп");
            }

            // task 3
            Console.Write("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            if (length > 0 && width > 0 && height > 0) Console.WriteLine($"Volume: {length * width * height}");
            else Console.WriteLine("Error");

            // task 4
            Console.Write("Map scale: ");
            double scale = Convert.ToDouble(Console.ReadLine());
            Console.Write("S: ");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(scale * S);

            // task 5
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"V = {(4.0 / 3.0) * Math.PI *  radius * radius * radius}");
            

        }
    }
}
