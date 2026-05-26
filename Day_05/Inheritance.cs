// Parent class (Base class)
class Animal
{
    public string Name { get; set; }
    public int Age  { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age  = age;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

// Child class (Derived class) — gets everything Animal has
class Dog : Animal       // ← colon means "inherits from"
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed)
        : base(name, age)   // ← calls Animal's constructor
    {
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

// In Main
Dog d = new Dog("Bruno", 3, "Labrador");
d.Eat();     // ✅ inherited from Animal
d.Sleep();   // ✅ inherited from Animal
d.Bark();    // ✅ Dog's own method