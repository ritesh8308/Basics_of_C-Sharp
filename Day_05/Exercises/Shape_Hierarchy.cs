/*

Exercise 2 — Shape Hierarchy
Abstract base: Shape(Color)
  → abstract: GetArea(), GetPerimeter()
  → concrete: PrintInfo() — prints all details

Derived: Circle(Radius), Rectangle(Width,Height), Triangle(A,B,C sides)
  → Triangle area: Heron's formula
     s = (a+b+c)/2
     area = √(s(s-a)(s-b)(s-c))

In Main:
  → Create array of Shape — mix of all three
  → Loop and call PrintInfo() on each
**/
using System;
namespace Day_05
{
    abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public void PrintInfo()
        {
            Console.WriteLine($"{"Shape:",-12} {GetType().Name}");
            Console.WriteLine($"{"Color:",-12} {Color}");
            Console.WriteLine($"{"Area:",-12} {GetArea():F2}");
            Console.WriteLine($"{"Perimeter:",-12} {GetPerimeter():F2}");
            Console.WriteLine(new string('-', 30));
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }

        public override double GetArea()      => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }

    class Rectangle : Shape
    {
        public double Width  { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, string color) : base(color)
        {
            Width  = width;
            Height = height;
        }

        public override double GetArea()      => Width * Height;
        public override double GetPerimeter() => 2 * (Width + Height);
    }

    class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c, string color) : base(color)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s-A) * (s-B) * (s-C));
        }

        public override double GetPerimeter() => A + B + C;
    }

    class Program
    {
        static void Main()
        {
            Shape[] shapes =
            {
                new Circle(5, "Red"),
                new Rectangle(4, 6, "Blue"),
                new Triangle(3, 4, 5, "Green")
            };

            foreach (Shape s in shapes)
            {
                s.PrintInfo();
            }
        }
    }
}