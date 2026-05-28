/*

Exercise 2 — Word Frequency Counter
Ask user to enter a sentence
Use Dictionary<string, int> to count
  how many times each word appears
Print results sorted by frequency (highest first)
Bonus: ignore case, ignore punctuation
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Day_06
{
    class WordFreqCounter
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("❌ Empty input!");
                return;
            }

            // Remove punctuation + lowercase
            string cleaned = Regex.Replace(input, @"[^\w\s]", "").ToLower();
            string[] words  = cleaned.Split(
                new[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            // Count frequencies
            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (freq.ContainsKey(word))
                    freq[word]++;
                else
                    freq[word] = 1;
            }

            // Sort by frequency descending
            var sorted = freq.OrderByDescending(pair => pair.Value);

            Console.WriteLine($"\n{"Word",-20} {"Count",-10}");
            Console.WriteLine(new string('─', 30));
            foreach (var pair in sorted)
                Console.WriteLine($"  {pair.Key,-18} → {pair.Value} time(s)");
        }
    }
}