class Animal
{
    public string Name { get; set; }
    public Animal(string name) { Name = name; }

    // virtual = child classes CAN override this
    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    // override = replacing parent's version
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Woof! 🐕");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Meow! 🐈");
    }
}

class Bird : Animal
{
    public Bird(string name) : base(name) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Tweet! 🐦");
    }
}

// THE MAGIC — Polymorphism
Animal[] animals = {
    new Dog("Bruno"),
    new Cat("Whiskers"),
    new Bird("Tweety")
};

foreach (Animal a in animals)
{
    a.Speak();    // calls correct version for each!
}

// Output:
// Bruno says: Woof! 🐕
// Whiskers says: Meow! 🐈
// Tweety says: Tweet! 🐦