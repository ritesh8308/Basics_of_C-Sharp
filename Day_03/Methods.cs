/*
A method is a named block of code you can call anytime instead of rewriting it.

static returnType MethodName(Parameters) {

return value;
}

*/

// void = returns nothing
static void Greet()
{
    Console.WriteLine("Hello, Ritesh!");
}

// int = returns a number
static int Add(int a, int b)
{
    return a + b;
}

// string = returns text
static string GetFullName(string first, string last)
{
    return $"{first} {last}";
}

// Calling them
static void Main()
{
    Greet();                          // Hello, Ritesh!
    int sum = Add(10, 5);             // sum = 15
    string name = GetFullName("Ritesh", "Mane");  // Ritesh Mane

    Console.WriteLine(sum);
    Console.WriteLine(name);
}