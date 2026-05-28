// Like a real dictionary — word(key) → definition(value)
Dictionary<string, int> scores = new Dictionary<string, int>();

// Adding
scores["Ritesh"] = 95;
scores["Rahul"]  = 87;
scores.Add("Rohit", 78);

// Reading
Console.WriteLine(scores["Ritesh"]);  // 95

// Safe reading — won't crash if key missing
if (scores.TryGetValue("Ravi", out int score))
    Console.WriteLine(score);
else
    Console.WriteLine("Key not found!");

// Checking
Console.WriteLine(scores.ContainsKey("Rahul"));   // true
Console.WriteLine(scores.ContainsValue(95));       // true

// Updating
scores["Ritesh"] = 100;    // overwrites existing

// Removing
scores.Remove("Rahul");

// Looping
foreach (KeyValuePair<string, int> pair in scores)
    Console.WriteLine($"{pair.Key,-15} → {pair.Value}");