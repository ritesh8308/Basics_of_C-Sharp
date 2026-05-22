// Optional parameter — has a default value
static void PrintInfo(string name, int age = 18, string city = "Mumbai")
{
    Console.WriteLine($"{name}, {age}, {city}");
}

PrintInfo("Ritesh");                        // Ritesh, 18, Mumbai
PrintInfo("Ritesh", 22);                    // Ritesh, 22, Mumbai
PrintInfo("Ritesh", 22, "Pune");            // Ritesh, 22, Pune

// Named arguments — pass in any order
PrintInfo(name: "Ritesh", city: "Pune");    // Ritesh, 18, Pune