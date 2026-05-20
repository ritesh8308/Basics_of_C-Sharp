/*

Ask user for temperature in Celsius.
Convert and print in Fahrenheit.
Formula: F = (C × 9/5) + 32

*/


using System;
namespace Day_01
{
    class E03
    {
        static void Main()
        {
            Console.Write("Enter temperature in °C: ");
            if (!double.TryParse(Console.ReadLine(), out double C))
            {
                Console.WriteLine("Invalid temperature entered!");
                return;
            }

            double F = (C * 9.0 / 5) + 32;
            Console.WriteLine($"Temperature: {F} °F");
        }
    }
}