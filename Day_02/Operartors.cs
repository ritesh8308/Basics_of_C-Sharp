using System;

namespace Day_02
{
    class Operators
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;

            Console.WriteLine(a + b);   // 13  addition
            Console.WriteLine(a - b);   // 7   subtraction
            Console.WriteLine(a * b);   // 30  multiplication
            Console.WriteLine(a / b);   // 3   integer division (decimal chopped!)
            Console.WriteLine(a % b);   // 1   remainder / modulus
            Console.WriteLine(10 / 3.0); // 3.333  use 3.0 for decimal result

            // Shorthand
            a += 5;   // a = a + 5  → 15
            a -= 2;   // a = a - 2  → 13
            a *= 2;   // a = a * 2  → 26
            a++;      // a = a + 1  → 27
            a--;      // a = a - 1  → 26

        }
    }
}