using System.Linq;

List<int> nums = new List<int> { 5, 3, 8, 1, 9, 2, 7, 4, 6, 3 };

// WHERE — filter
var big   = nums.Where(n => n > 5);              // 8, 9, 7, 6

// SELECT — transform/project
var doubled = nums.Select(n => n * 2);           // 10, 6, 16...

// ORDERBY / ORDERBYDESCENDING — sort
var asc  = nums.OrderBy(n => n);                 // 1,2,3,3,4,5,6,7,8,9
var desc = nums.OrderByDescending(n => n);       // 9,8,7,6,5,4,3,3,2,1

// FIRST / LAST
var first = nums.First();                        // 5
var last  = nums.Last();                         // 3
var firstBig = nums.First(n => n > 5);          // 8

// FIRSTORDEFAULT — won't crash if not found
var found = nums.FirstOrDefault(n => n > 100);  // 0 (default for int)

// COUNT / SUM / MIN / MAX / AVERAGE
Console.WriteLine(nums.Count());                 // 10
Console.WriteLine(nums.Count(n => n > 5));       // 4
Console.WriteLine(nums.Sum());                   // 48
Console.WriteLine(nums.Min());                   // 1
Console.WriteLine(nums.Max());                   // 9
Console.WriteLine(nums.Average());               // 4.8

// ANY / ALL
Console.WriteLine(nums.Any(n => n > 8));         // true
Console.WriteLine(nums.All(n => n > 0));         // true

// DISTINCT — removes duplicates
var unique = nums.Distinct();                    // 5,3,8,1,9,2,7,4,6

// TAKE / SKIP
var top3    = nums.OrderByDescending(n => n).Take(3);   // 9,8,7
var skip3   = nums.OrderBy(n => n).Skip(3);             // 3,4,5,6,7,8,9

// GROUPBY
var groups = nums.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
foreach (var group in groups)
{
    Console.Write($"{group.Key}: ");
    foreach (var n in group) Console.Write($"{n} ");
    Console.WriteLine();
}