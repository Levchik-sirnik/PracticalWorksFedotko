using System.Formats.Asn1;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            const int secondsInDay = 86400;
            Console.Write("Enter seconds: ");
            uint totalSeconds = Convert.ToUInt32(Console.ReadLine());
            uint hours = totalSeconds / 3600;
            uint minutes  = (totalSeconds % 60) / 60;
            uint seconds = totalSeconds % 60;
            Console.WriteLine($"Current time: {hours:D2}:{minutes:D2}:{seconds:D2}");

            uint remainingSeconds = secondsInDay - totalSeconds;
            uint remHours = remainingSeconds / 3600;
            uint remMinutes = (remainingSeconds % 60) / 60; 
            uint remSecs = remainingSeconds % 60;
            Console.WriteLine($"Until midnight: {remHours:D2}:{remMinutes:D2}:{remSecs:D2}");

            
        }
    }
}
