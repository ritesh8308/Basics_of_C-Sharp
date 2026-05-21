/*

Print numbers 1 to 100
Multiples of 3 → print "Fizz"
Multiples of 5 → print "Buzz"
Multiples of both → print "FizzBuzz"
Otherwise → print the number

*/

using System;
namespace Day_02
{
    class FizzBuzz
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}