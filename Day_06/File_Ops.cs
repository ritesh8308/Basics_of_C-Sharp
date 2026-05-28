using System.IO;

// WRITE — creates file, overwrites if exists
File.WriteAllText("notes.txt", "Hello Ritesh!\nDay 6 complete!");

// READ — reads entire file as string
string content = File.ReadAllText("notes.txt");
Console.WriteLine(content);

// READ ALL LINES — reads into string array
string[] lines = File.ReadAllLines("notes.txt");
foreach (string line in lines)
    Console.WriteLine(line);

// APPEND — adds to existing file without overwriting
File.AppendAllText("notes.txt", "\nNew line added!");

// CHECK if file exists
if (File.Exists("notes.txt"))
    Console.WriteLine("File found!");

// DELETE
File.Delete("notes.txt");