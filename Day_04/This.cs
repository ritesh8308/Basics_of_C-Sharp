class Person
{
    public string Name { get; set; }
    public int Age  { get; set; }

    public Person(string name, int age)
    {
        // 'this.Name' = the class field
        // 'name' = the parameter
        this.Name = name;   // avoids naming confusion
        this.Age  = age;
    }

    // this = refers to current object
    public void PrintSelf()
    {
        Console.WriteLine($"I am {this.Name}");
    }
}