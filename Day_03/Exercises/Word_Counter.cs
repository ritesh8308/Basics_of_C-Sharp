/*

Ask user to enter a sentence
Count: total words, total characters, total vowels
Bonus: count how many times each word appears
*/

using System;
using System.Collections.Generic;
namespace Day_03
{
    class WordCounter
    {
        static int CountWords(string[] words)
        {
            return words.Length;
        }

        static int CountCharacters(string sentence)
        {
            return sentence.Replace(" ", "").Length;
        }

        static int CountVowels(string sentence)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in sentence)
            {
                if (vowels.Contains(c))
                    count++;
            }
            return count;
        }

        static void WordFrequency(string[] words)
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string w = word.ToLower();
                if (freq.ContainsKey(w))
                    freq[w]++;
                else
                    freq[w] = 1;
            }

            Console.WriteLine("\nWord Frequency:");
            foreach (var pair in freq)
                Console.WriteLine($"  '{pair.Key}' → {pair.Value} time(s)");
        }

        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Empty input!");
                return;
            }

            // Split once, reuse everywhere
            string[] words = sentence.Trim().Split(' ');

            Console.WriteLine($"\nTotal words:      {CountWords(words)}");
            Console.WriteLine($"Total characters: {CountCharacters(sentence)}");
            Console.WriteLine($"Total vowels:     {CountVowels(sentence)}");

            WordFrequency(words);
        }
    }
}