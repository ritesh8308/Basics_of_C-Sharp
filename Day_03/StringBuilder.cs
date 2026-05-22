using System.Text;   // needed for StringBuilder

// ❌ Bad — creates a NEW string object every ++ in a loop (slow)
string result = "";
for (int i = 0; i < 100; i++)
    result += i + ", ";

// ✅ Good — StringBuilder modifies one object (fast)
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 100; i++)
    sb.Append(i + ", ");

Console.WriteLine(sb.ToString());