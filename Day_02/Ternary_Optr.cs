using System;

namespace Day_02
{
    class Ternary_Operatro
    {
        static void Main(string[] args)
        {
            int age = 20;

            // condition ? value_if_true : value_if_false
            string result = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine(result);   // Adult

            // Same as:
            // if (age >= 18) result = "Adult";
            // else result = "Minor";
        }
    }
}