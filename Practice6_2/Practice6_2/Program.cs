using System;
using System.Diagnostics;

namespace Practice6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Random random = new Random();
            int guess = random.Next(1, 501);
            int attempts = 1;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            Console.Write("Guess a number between 1 and 500: ");
            int userGuess = int.Parse(Console.ReadLine()!);

            while (userGuess != guess || userGuess == 0)
            {
                if (userGuess < guess)
                {
                    Console.WriteLine("Your guess is too low.");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("Your guess is too high.");
                    attempts++;
                }
                Console.Write("Guess a number between 1 and 500 (enter 0 to quit): ");
                userGuess = int.Parse(Console.ReadLine()!);
            }

            timer.Stop();
            Console.WriteLine("Congratulations! You guessed the number.");
            Console.WriteLine($"Number of attempts: {attempts}");

            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            Console.WriteLine($"Time taken: {elapsedTime}");


            // task 2
            Console.Write("Введите сумму: ");
            double amount = double.Parse(Console.ReadLine()!);
            Console.Write("Введите валюту ввода (1 - USD, 2 - EUR, 3 - RUB): ");
            int inputCurrency = int.Parse(Console.ReadLine()!);
            Console.Write("Введите валюту вывода (1 - USD, 2 - EUR, 3 - RUB): ");
            int outputCurrency = int.Parse(Console.ReadLine()!);
            ConvertCurrency(amount, inputCurrency, outputCurrency);
        }

        static void ConvertCurrency(double amount, int inputCurrency, int outputCurrency)
        {
            double convertedAmount = 0;
            switch (inputCurrency)
            {
                case 1: // USD
                    if (outputCurrency == 2) // EUR
                        convertedAmount = amount * 0.85;
                    else if (outputCurrency == 3) // RUB
                        convertedAmount = amount * 75.0;
                    else
                        convertedAmount = amount; // USD to USD
                    break;
                case 2: // EUR
                    if (outputCurrency == 1) // USD
                        convertedAmount = amount * 1.18;
                    else if (outputCurrency == 3) // RUB
                        convertedAmount = amount * 88.0;
                    else
                        convertedAmount = amount; // EUR to EUR
                    break;
                case 3: // RUB
                    if (outputCurrency == 1) // USD
                        convertedAmount = amount * 0.013;
                    else if (outputCurrency == 2) // EUR
                        convertedAmount = amount * 0.011;
                    else
                        convertedAmount = amount; // RUB to RUB
                    break;
                default:
                    Console.WriteLine("Неверный выбор валюты.");
                    return;
            }
            Console.WriteLine($"Конвертированная сумма: {convertedAmount}");
        }
    }
}
