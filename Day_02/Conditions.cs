using System;

namespace Day_02
{
    class Conditions
    {
        static void Main(string[] args)
        {
            
            int age = 20;
            bool hasID = true;

            // && = AND — both must be true
            Console.WriteLine(age >= 18 && hasID);   // True

            // || = OR — at least one must be true
            Console.WriteLine(age <= 18 || hasID);   // True

            // ! = NOT — flips true/false
            Console.WriteLine(!hasID);               // False

            
        }
    }
}