int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Method syntax — more common, used by professionals
var result1 = nums
    .Where(n => n % 2 == 0)
    .OrderByDescending(n => n)
    .Select(n => n * n);

// Query syntax — looks like SQL
var result2 = from n in nums
              where n % 2 == 0
              orderby n descending
              select n * n;

// Both produce identical results
// Method syntax is preferred in modern C#