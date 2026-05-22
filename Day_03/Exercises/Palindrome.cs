/**

Ask user for a string
Reverse it WITHOUT using built-in Reverse()
Also check if it's a palindrome (same forwards & backwards)
Example: "madam" → is a palindrome
*/

using System;
using System.Text;
namespace Day_03
{
    class Palindrome
    {
        static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        static bool IsPalindrome(string original, string reversed)
        {
            return original.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Empty input entered!");
                return;
            }

            string reversed = ReverseString(s);

            Console.WriteLine($"\nOriginal: {s}");
            Console.WriteLine($"Reversed: {reversed}");

            if (IsPalindrome(s, reversed))
                Console.WriteLine($"\n'{s}' IS a palindrome ✅");
            else
                Console.WriteLine($"\n'{s}' is NOT a palindrome ❌");
        }
    }
}