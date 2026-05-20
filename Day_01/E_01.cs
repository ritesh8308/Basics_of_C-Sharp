/**

Write a program that asks for: name, age, city
Then prints:
--- My Card ---
Name: Rahul
Age: 22
City: Mumbai


*/

using System;
namespace Day_01
{
    class E01
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age entered!");
                return;
            }

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.WriteLine("--- My Card ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age:  {age}");
            Console.WriteLine($"City: {city}");
        }
    }
}