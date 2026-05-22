// Declare and initialize
int[] numbers = new int[5];           // 5 slots, all 0 by default
int[] scores = { 85, 92, 78, 95, 88 }; // initialize with values

// Access by index (starts at 0)
Console.WriteLine(scores[0]);    // 85  ← first
Console.WriteLine(scores[4]);    // 88  ← last
Console.WriteLine(scores.Length); // 5

// Modify
scores[0] = 100;

// Loop through array
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"scores[{i}] = {scores[i]}");
}

// foreach — cleaner when you don't need the index
foreach (int score in scores)
{
    Console.WriteLine(score);
}