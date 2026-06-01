// Action — delegate that returns void
Action<string> greet = name => Console.WriteLine($"Hello {name}!");
greet("Ritesh");   // Hello Ritesh!




// Func — delegate that returns a value
// Func<input, output>
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 5));   // 8

Func<string, bool> isLong = s => s.Length > 10;
Console.WriteLine(isLong("Hello"));        // false
Console.WriteLine(isLong("Hello Ritesh")); // true