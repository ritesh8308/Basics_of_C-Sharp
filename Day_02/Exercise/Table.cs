/*

Ask user for a number
Print its multiplication table from 1 to 10
Example for 5:
5 x 1 = 5
5 x 2 = 10
...
5 x 10 = 50

*/


using System;
namespace Day_02
{
    class Table
    {
        static void Main()
        {
            Console.WriteLine("Press Escape anytime to exit\n");

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // check if user just pressed Escape or typed 'exit'
                if (input.ToLower() == "exit" || input == "") break;

                if (!int.TryParse(input, out int a))
                {
                    Console.WriteLine("Invalid! Numbers only.\n");
                    continue;
                }

                Console.WriteLine();
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{a} x {i,2} = {a * i,3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Goodbye!");
        }
    }
}