/*
Create methods: Add, Subtract, Multiply, Divide
Each takes two doubles and returns result
Divide should handle division by zero
Main: ask user for two numbers + operation → show result
*/

using System;
namespace Day_03
{
    class Calculator
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is undefined!");
                return double.NaN;
            }
            return a / b;
        }

        static void Main()
        {
            Console.Write("Enter first number:  ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine($"\nAddition:       {Add(a, b)}");
            Console.WriteLine($"Subtraction:    {Subtract(a, b)}");
            Console.WriteLine($"Multiplication: {Multiply(a, b)}");
            Console.WriteLine($"Division:       {Divide(a, b)}");
        }
    }
}