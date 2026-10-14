using System;

namespace Practice4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter 5 marks: ");
            string[] marks = Console.ReadLine()!.Split(' ');

            double mark1 = double.Parse(marks[0]);
            double mark2 = double.Parse(marks[1]);
            double mark3 = double.Parse(marks[2]);
            double mark4 = double.Parse(marks[3]);
            double mark5 = double.Parse(marks[4]);

            double avScore = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;

            if (avScore >= 4) Console.WriteLine("Average score: " + avScore + " - Pass");
            else Console.WriteLine("Average score: " + avScore + " - Fail");


            // task 2
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine()!);
            if (number % 2 == 0) Console.WriteLine(number * 3);
            else Console.WriteLine((double)number / 2);


            // task 3
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите действие (+, -, *, /): ");
            string op = Console.ReadLine()!;

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            string result = op switch
            {
                "+" => $"{num1 + num2}",
                "-" => $"{num1 - num2}",
                "*" => $"{num1 * num2}",
                "/" => num2 != 0 ? $"{num1 / num2}" : "Ошибка: Деление на ноль",
                _ => "Ошибка: Неверная операция"
            };

            Console.WriteLine($"Результат: {result}");


        }
    }
}
