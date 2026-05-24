/**

Exercise 3 — Rectangle Class 📐
Create a class Rectangle with:

Properties:
  Width  → double
  Height → double

Constructor:
  Takes width and height
  Reject negative values — set to 0 if negative

Methods:
  GetArea()       → Width * Height
  GetPerimeter()  → 2 * (Width + Height)
  IsSquare()      → return true if Width == Height
  PrintInfo()     → print all details neatly

Bonus:
  Static method Compare(Rectangle r1, Rectangle r2)
  → prints which rectangle has larger area






Expected Output:
========= Rectangle =========
Width:     5.00
Height:    5.00
Area:      25.00
Perimeter: 20.00
Is Square: Yes ✅
=============================
*/


using System;
namespace Day_04
{
    class Rectangle
    {
        // Properties
        public double Width  { get; set; }
        public double Height { get; set; }

        // Parameterized Constructor
        public Rectangle(double width, double height)
        {
            Width  = width  < 0 ? 0 : width;
            Height = height < 0 ? 0 : height;
        }

        // Methods
        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public bool IsSquare()
        {
            return Width == Height;
        }

        public void PrintInfo()
        {
            Console.WriteLine("======= Rectangle =======");
            Console.WriteLine($"{"Width:",-12} {Width:F2}");
            Console.WriteLine($"{"Height:",-12} {Height:F2}");
            Console.WriteLine($"{"Area:",-12} {GetArea():F2}");
            Console.WriteLine($"{"Perimeter:",-12} {GetPerimeter():F2}");
            Console.WriteLine($"{"Is Square:",-12} {(IsSquare() ? "Yes ✅" : "No ❌")}");
            Console.WriteLine("=========================");
        }

        // Bonus — Static Compare
        public static void Compare(Rectangle r1, Rectangle r2)
        {
            double area1 = r1.GetArea();
            double area2 = r2.GetArea();

            if (area1 > area2)
                Console.WriteLine($"Rectangle 1 is larger — Area: {area1:F2}");
            else if (area2 > area1)
                Console.WriteLine($"Rectangle 2 is larger — Area: {area2:F2}");
            else
                Console.WriteLine("Both rectangles are equal in area!");
        }

        static void Main()
        {
            Rectangle r1 = new Rectangle(5, 5);
            Rectangle r2 = new Rectangle(8, 3);

            r1.PrintInfo();
            Console.WriteLine();
            r2.PrintInfo();
            Console.WriteLine();

            Rectangle.Compare(r1, r2);

            // Test negative rejection
            Rectangle r3 = new Rectangle(-5, 10);
            Console.WriteLine($"\nNegative test — Width: {r3.Width}");
        }
    }
}