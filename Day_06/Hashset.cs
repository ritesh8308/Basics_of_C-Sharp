HashSet<string> tags = new HashSet<string>();

tags.Add("csharp");
tags.Add("dotnet");
tags.Add("csharp");    // duplicate — silently ignored!
tags.Add("oop");

Console.WriteLine(tags.Count);             // 3 not 4
Console.WriteLine(tags.Contains("oop"));   // true

// Great for removing duplicates from a list
List<int> withDups   = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
HashSet<int> unique  = new HashSet<int>(withDups);
// unique = { 1, 2, 3, 4 }