using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int secondsInDay = 86400;
            Console.Write("Enter seconds: ");
            int totalSeconds = Convert.ToInt32(Console.ReadLine());

            int currentHours = totalSeconds / 3600;
            int currentMinutes = (totalSeconds % 3600) / 60;
            int currentSeconds = totalSeconds % 60;
            Console.WriteLine($"Current time: {currentHours:D2}:{currentMinutes:D2}:{currentSeconds:D2}");

            int leftTotalSeconds = secondsInDay - totalSeconds;
            int leftHours = leftTotalSeconds / 3600;
            int leftMinutes = (leftTotalSeconds % 3600) / 60;
            int leftSeconds = leftTotalSeconds % 60;
            Console.WriteLine($"Current time: {leftHours:D2}:{leftMinutes:D2}:{leftSeconds:D2}");


            // task 2
            Console.Write("Enetr diametr: ");
            double diametr = Convert.ToDouble(Console.ReadLine());

            double radius = diametr * 0.5;
            double P = Math.PI * diametr;
            double S = Math.PI * radius * radius;

            Console.WriteLine($"P: {P}");
            Console.WriteLine($"S: {S}");

        }


    }

}


