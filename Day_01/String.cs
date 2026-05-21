using System;

namespace Day_01
{
    class String
    {
        static void Main(string[] args)
        {
            string first = "Rahul";
            string last = "Sharma";

            // Concatenation
            string full = first + " " + last;

            // String Interpolation — PREFERRED ✅
            string greeting = $"Hello, {first} {last}!";
            Console.WriteLine(greeting);  // Hello, Rahul Sharma!

            // Useful string methods
            string text = "  Hello World  ";
            Console.WriteLine(text.ToUpper());       // HELLO WORLD
            Console.WriteLine(text.ToLower());       // hello world
            Console.WriteLine(text.Trim());          // "Hello World" (removes spaces)
            Console.WriteLine(text.Length);          // 15
            Console.WriteLine(text.Contains("World")); // True
            Console.WriteLine(text.Replace("World", "C#")); // Hello C#
        }
    }
}



