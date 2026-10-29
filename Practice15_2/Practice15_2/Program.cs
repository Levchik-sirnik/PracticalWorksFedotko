using System;

namespace Practice15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            string text = "Cтрока для проверки замены";
            string result = text.Replace(" ", "\t");
            Console.WriteLine($"Результат: {result}\n");


            // task 2
            string text2 = "1С - четкая тема в 2026 году";
            Console.WriteLine(text2);
            int letters = 0;
            int digits = 0;
            int others = 0;

            foreach (char ch in text2)
            {
                if (char.IsLetter(ch)) letters++;
                else if (char.IsDigit(ch)) digits++;
                else others++;
            }

            Console.WriteLine($"Кол-во букв: {letters}");
            Console.WriteLine($"Кол-во цифр: {digits}");
            Console.WriteLine($"Кол-во других символов: {others}\n");


            // task 3
            Console.Write("Введите предложение: ");
            string text3 = Console.ReadLine()!;
            string[] words = text3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Кол-во слов: {words.Length}\n");


            // task 4
            string text4 = "А роза упала на лапу Азора";
            if (IsPalindrome(text4)) Console.WriteLine("Строка является палиндромом.");
            else Console.WriteLine("Строка НЕ является палиндромом.");
        }

        static bool IsPalindrome(string str)
        {
            string cleaned = str.ToLower().Replace(" ", "");

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right]) return false; 
                left++;
                right--;
            }
            return true;
        }
    }
}
