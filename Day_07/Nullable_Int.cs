// int can't be null by default
int age = null;     // ❌ compile error

// int? makes it nullable
int? age = null;    // ✅
int? score = 95;

// Check before using
if (age.HasValue)
    Console.WriteLine(age.Value);
else
    Console.WriteLine("Age not set");

// Null coalescing — provide default if null
int result = age ?? 0;      // if age is null → use 0
string name = null;
string display = name ?? "Unknown";   // if null → "Unknown"

// Null conditional — don't crash on null
string s = null;
int? len = s?.Length;   // if s is null → len = null (no crash!)