string text = "  Hello, Ritesh!  ";

// Cleaning
Console.WriteLine(text.Trim());              // "Hello, Ritesh!"
Console.WriteLine(text.TrimStart());         // "Hello, Ritesh!  "
Console.WriteLine(text.TrimEnd());           // "  Hello, Ritesh!"

// Case
Console.WriteLine(text.ToUpper());           // "  HELLO, RITESH!  "
Console.WriteLine(text.ToLower());           // "  hello, ritesh!  "

// Searching
Console.WriteLine(text.Contains("Ritesh")); // True
Console.WriteLine(text.StartsWith("  H"));  // True
Console.WriteLine(text.IndexOf("Ritesh"));  // 9

// Modifying
Console.WriteLine(text.Replace("Ritesh", "World"));  // Hello, World!
Console.WriteLine(text.Trim().Remove(5));             // "Hello"

// Splitting & Joining
string csv = "apple,banana,mango";
string[] fruits = csv.Split(',');       // ["apple", "banana", "mango"]
foreach (string fruit in fruits)
    Console.WriteLine(fruit);

string joined = string.Join(" - ", fruits);  // "apple - banana - mango"
Console.WriteLine(joined);

// Substring
string name = "Ritesh Mane";
Console.WriteLine(name.Substring(0, 6));     // "Ritesh"
Console.WriteLine(name.Substring(7));        // "Mane"

// Length
Console.WriteLine(name.Length);             // 11