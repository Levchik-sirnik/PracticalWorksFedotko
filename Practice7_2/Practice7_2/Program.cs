using System;

namespace Practice7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine("=== Проверка знания таблицы умножения ===");
            Console.WriteLine("Выберите уровень сложности:");
            Console.WriteLine("1 — Легкий (5 вопросов, числа от 2 до 5)");
            Console.WriteLine("2 — Средний (10 вопросов, числа от 2 до 9)");
            Console.WriteLine("3 — Сложный (15 вопросов, числа от 11 до 19)");
            Console.Write("Введите номер уровня (1-3): ");

            short level;
            while (!short.TryParse(Console.ReadLine(), out level) || level < 1 || level > 3)
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите номер уровня (1-3): ");
            }

            int totalQuestions = 0;
            int minNumber = 2;
            int maxNumber = 9;

            switch (level)
            {
                case 1:
                    totalQuestions = 5;
                    minNumber = 2;
                    maxNumber = 5;
                    break;

                case 2:
                    totalQuestions = 10;
                    minNumber = 2;
                    maxNumber = 9;
                    break;

                case 3:
                    totalQuestions = 15;
                    minNumber = 11;
                    maxNumber = 19;
                    break;
            }

            Random random = new Random();
            int correctAnswersCount = 0;

            Console.WriteLine($"\nТест начался! Вам предстоит ответить на {totalQuestions} вопросов.\n");

            for (int i = 1; i <= totalQuestions; i++)
            {
                int num1 = random.Next(minNumber, maxNumber + 1);
                int num2 = random.Next(minNumber, maxNumber + 1);
                int correctAnswer = num1 * num2;

                Console.Write($"Вопрос {i}: {num1} * {num2} = ");

                int userAnswer;
                while (!int.TryParse(Console.ReadLine(), out userAnswer))
                {
                    Console.Write("Некорректный ввод. Пожалуйста, введите целое число: ");
                }

                if (userAnswer == correctAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Правильно!");
                    Console.ResetColor();
                    correctAnswersCount++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Неправильно! Правильный ответ: {correctAnswer}");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            double successRate = (double)correctAnswersCount / totalQuestions * 100;
            int grade;
            if (successRate >= 90) grade = 5;
            else if (successRate >= 75) grade = 4;
            else if (successRate >= 60) grade = 3;
            else grade = 2;

            Console.WriteLine("========================================");
            Console.WriteLine($"Тест завершен! Правильных ответов: {correctAnswersCount} из {totalQuestions}.");
            Console.WriteLine($"Процент успешности: {successRate:F1}%");

            Console.Write("Ваша оценка: ");
            if (grade == 5) Console.ForegroundColor = ConsoleColor.Green;
            else if (grade == 4) Console.ForegroundColor = ConsoleColor.Blue;
            else if (grade == 3) Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(grade);
            Console.ResetColor();

            Console.WriteLine("========================================");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();


            // task 2
            Console.WriteLine("Enter rhombus side length: ");
            int sideLength;
            while (!int.TryParse(Console.ReadLine(), out sideLength) || sideLength <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the side length: ");
            }

            for (int i = 1; i <= sideLength; i++)
            {
                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = sideLength - 1; i >= 1; i--)
            {
                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
