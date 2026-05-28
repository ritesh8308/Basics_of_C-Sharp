// ❌ manual — easy to forget Dispose()
StreamWriter sw = new StreamWriter("file.txt");
sw.WriteLine("data");
sw.Dispose();   // easy to forget!

// ✅ using — auto disposes when block ends
using (StreamWriter sw = new StreamWriter("file.txt"))
{
    sw.WriteLine("data");
}   // sw.Dispose() called automatically here ✅

// Modern C# — even cleaner
using StreamWriter sw = new StreamWriter("file.txt");
sw.WriteLine("data");
// disposed at end of method automatically