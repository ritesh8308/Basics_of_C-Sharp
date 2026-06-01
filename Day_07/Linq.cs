int[] numbers = { 5, 3, 8, 1, 9, 2, 7, 4, 6 };

// ❌ Without LINQ — verbose
List<int> result = new List<int>();
foreach (int n in numbers)
    if (n > 5) result.Add(n);
result.Sort();

// ✅ With LINQ — one clean line
var result = numbers.Where(n => n > 5).OrderBy(n => n).ToList();