Console.Write("Enter your name: ");   // Write = no newline
string name = Console.ReadLine();      // Reads user input as string

Console.WriteLine("Hello, " + name + "!");

// Reading a number requires conversion
Console.Write("Enter your age: ");
string input = Console.ReadLine();
int age = int.Parse(input);            // Convert string → int

Console.WriteLine("You are " + age + " years old.");