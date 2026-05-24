class Person
{
    // Fields — data the class holds (private by default)
    private string name;
    private int age;

    // Properties — controlled access to fields
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Auto-property — shorthand (most common)
    public int Age { get; set; }

    // Read-only property — can get, cannot set from outside
    public bool IsAdult { get { return age >= 18; } }

    // Method — behavior
    public void Greet()
    {
        Console.WriteLine($"Hi! I am {name}, {age} years old.");
    }
}