// Interface = pure contract — NO implementation, just method signatures
// Think of it as: "I PROMISE this class will have these methods"
interface IAnimal
{
    void Speak();       // no body
    void Move();        // no body
    string Name { get; }
}

// A class can implement MULTIPLE interfaces (unlike inheritance — only one parent)
interface ISwimmable
{
    void Swim();
}

interface IFlyable
{
    void Fly();
}

class Duck : Animal, ISwimmable, IFlyable   // one parent, two interfaces
{
    public Duck(string name) : base(name) { }

    public override void Speak() =>
        Console.WriteLine($"{Name} says: Quack!");

    public void Swim() =>
        Console.WriteLine($"{Name} is swimming.");

    public void Fly() =>
        Console.WriteLine($"{Name} is flying.");
}