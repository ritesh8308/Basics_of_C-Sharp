/*

Exercise 1 — Animal Hierarchy
Abstract base: Animal(Name, Age)
  → abstract method: Speak()
  → virtual method:  Describe() — prints name & age

Derived classes: Dog, Cat, Bird
  → each overrides Speak() differently
  → Dog extra: Fetch()
  → Cat extra: Purr()
  → Bird extra: Fly()

In Main:
  → Create array of Animal — put Dog, Cat, Bird in it
  → Loop and call Speak() on each (polymorphism)
  → Call Describe() on each
*/



using System;
namespace Day_05
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age  { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age  = age;
        }

        public abstract void Speak();

        public virtual void Describe()
        {
            Console.WriteLine($"{"Name:",-10} {Name}");
            Console.WriteLine($"{"Age:",-10} {Age} yrs");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof! 🐕");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name}: fetching the ball!");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Meow! 🐈");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring...");
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Tweet! 🐦");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying!");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog("Bruno",   3),
                new Cat("Sinee",   1),
                new Bird("Tweety", 2)
            };

            foreach (Animal a in animals)
            {
                a.Speak();
                a.Describe();

                if (a is Dog  dog)  dog.Fetch();
                if (a is Cat  cat)  cat.Purr();
                if (a is Bird bird) bird.Fly();

                Console.WriteLine(new string('-', 25));
            }
        }
    }
}