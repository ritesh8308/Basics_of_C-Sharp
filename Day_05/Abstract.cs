// abstract = cannot create object of this class directly
// it's purely a blueprint for child classes
abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    // abstract method = NO body here — child MUST implement it
    public abstract double GetArea();
    public abstract double GetPerimeter();

    // regular method — inherited as-is
    public void PrintInfo()
    {
        Console.WriteLine($"Color:     {Color}");
        Console.WriteLine($"Area:      {GetArea():F2}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F2}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    // MUST implement abstract methods
    public override double GetArea()      => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}

class Rectangle : Shape
{
    public double Width  { get; set; }
    public double Height { get; set; }

    public Rectangle(string color, double w, double h) : base(color)
    {
        Width = w; Height = h;
    }

    public override double GetArea()      => Width * Height;
    public override double GetPerimeter() => 2 * (Width + Height);
}

// Shape s = new Shape("red");  ❌ can't create abstract class
Circle c = new Circle("Red", 5);
c.PrintInfo();