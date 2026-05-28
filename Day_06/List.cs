using System.Collections.Generic;

// Unlike arrays — size grows automatically
List<string> names = new List<string>();

// Adding
names.Add("Ritesh");
names.Add("Rahul");
names.Add("Rohit");

// Insert at position
names.Insert(1, "Ravi");   // index 1

// Removing
names.Remove("Rahul");          // by value
names.RemoveAt(0);              // by index

// Checking
Console.WriteLine(names.Count);          // length
Console.WriteLine(names.Contains("Ravi")); // true/false
Console.WriteLine(names.IndexOf("Ravi")); // position

// Looping
foreach (string name in names)
    Console.WriteLine(name);

// List of objects
List<int> numbers = new List<int> { 5, 3, 8, 1, 9 };
numbers.Sort();                  // sorts in place
numbers.Reverse();               // reverses in place
Console.WriteLine(numbers[0]);   // access by index