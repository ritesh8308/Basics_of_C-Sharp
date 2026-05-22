static int Add(int a, int b)
{
    return a + b;
}

static double Add(double a, double b)
{
    return a + b;
}

static int Add(int a, int b, int c)
{
    return a + b + c;
}

// C# picks the right one based on what you pass
Console.WriteLine(Add(2, 3));         // 5    → uses int version
Console.WriteLine(Add(2.5, 3.5));     // 6.0  → uses double version
Console.WriteLine(Add(1, 2, 3));      // 6    → uses 3-param version