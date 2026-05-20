/*

Ask user for radius.
Calculate and print: Area and Circumference
Formula: Area = π × r²,  Circumference = 2 × π × r

*/


using System;
namespace Day_01
{
    class E02
    {
        static void Main()
        {
            const double PI = 3.14159;

            Console.Write("Enter radius: ");
            if (!double.TryParse(Console.ReadLine(), out double r))
            {
                Console.WriteLine("Invalid radius entered!");
                return;
            }

            double area = PI * r * r;
            double perimeter = 2 * PI * r;

            Console.WriteLine($"Area:      {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}