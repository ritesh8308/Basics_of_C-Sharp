class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)  // base() calls parent constructor
    { }

    public override void Speak()
    {
        base.Speak();    // calls Animal's Speak() first
        Console.WriteLine($"{Name} says: Woof!");
    }
}

// Output:
// Bruno makes a sound.
// Bruno says: Woof!