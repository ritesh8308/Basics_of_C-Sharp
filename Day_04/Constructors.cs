class Person
{
    public string Name { get; set; }
    public int Age  { get; set; }

    // Default constructor — no parameters
    public Person()
    {
        Name = "Unknown";
        Age  = 0;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age  = age;
    }

    // Constructor chaining — call another constructor
    public Person(string name) : this(name, 18)
    {
        // calls Person(name, 18) automatically
    }
}

// Creating objects
Person p1 = new Person();                  // default → Unknown, 0
Person p2 = new Person("Ritesh", 22);      // parameterized
Person p3 = new Person("Rahul");           // chained → Rahul, 18