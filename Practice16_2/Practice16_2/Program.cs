using System;
using System.Text.RegularExpressions;

namespace Practice16_2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string text = "Diamonds on my head, diamonds on my shoe.\r\n" +
                "Take you back to school, baby, what it do?\r\n" +
                "Everything cool, everything cool.\r\n" +
                "I just wanna move if you down to move.\r\n" +
                "Show me what it do, baby, what it do?\r\n" +
                "Diamonds on my head, diamonds on my shoe.\r\n" +
                "Everything cool at the rendezvous.";
            Console.WriteLine($"Original text:\n{text}\n");
            
            // task 1
            Console.Write("Enter a word to search for: ");
            string searchWord = Console.ReadLine()!;

            int wordCount = Regex.Matches(text, @"\b" + Regex.Escape(searchWord) + @"\b", RegexOptions.IgnoreCase).Count;
            Console.WriteLine($"Number of occurrences: {wordCount}\n");


            // task 2
            int sentenceCount = Regex.Matches(text, @"[.!?]").Count;
            Console.WriteLine($"Number of sentences: {sentenceCount}\n");


            // task 3
            int periodCount = text.Count(p => p == '.');
            int commaCount = text.Count(c => c == ',');
            Console.WriteLine($"Number of periods: {periodCount}");
            Console.WriteLine($"Number of commas: {commaCount}\n");


            // task 4
            char[] textArr = text.ToCharArray();
            Array.Reverse(textArr);
            string reversedText = new string(textArr);
            Console.WriteLine($"Reversed text: {reversedText}\n");


            // task 5
            string[] senteces = Regex.Split(text, @"(?<=[.!?])");

            var reversedSenteces = senteces
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s =>
                {
                    char[] sArr = s.Trim().ToCharArray();
                    Array.Reverse(sArr);
                    return new string(sArr);
                });

            string reversedSentencesText = string.Join(" ", reversedSenteces);
            Console.WriteLine($"Reversed sentences text: {reversedSentencesText}");
        }
    }
}
