// Lambda syntax:
// (parameter) => expression

// Regular method
static bool IsEven(int n) { return n % 2 == 0; }

// Same thing as lambda
n => n % 2 == 0

// Used in LINQ
numbers.Where(n => n % 2 == 0)   // filter even numbers