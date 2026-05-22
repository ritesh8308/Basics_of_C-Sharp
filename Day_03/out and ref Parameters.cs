// ref — pass variable BY REFERENCE (must be initialized first)
static void Double(ref int x)
{
    x = x * 2;
}

int num = 5;
Double(ref num);
Console.WriteLine(num);    // 10 — original changed!

// out — method sets the value (no need to initialize)
static void Divide(int a, int b, out int result, out int remainder)
{
    result = a / b;
    remainder = a % b;
}

Divide(17, 5, out int res, out int rem);
Console.WriteLine($"Result: {res}, Remainder: {rem}");  // Result: 3, Remainder: 2