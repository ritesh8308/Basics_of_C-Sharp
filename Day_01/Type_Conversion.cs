// Implicit (safe, no data loss)
int x = 10;
double y = x;      // int → double ✅ automatic

// Explicit casting (possible data loss)
double pi = 3.99;
int truncated = (int)pi;   // = 3  (decimal chopped off!)

// Parse (string → number)
int num = int.Parse("42");
double d = double.Parse("3.14");

// Safe Parse — doesn't crash if input is bad
bool success = int.TryParse("abc", out int result);
Console.WriteLine(success);  // False
Console.WriteLine(result);   // 0 (default)

// Convert class
int fromBool = Convert.ToInt32(true);   // = 1
string fromInt = Convert.ToString(99);  // = "99"