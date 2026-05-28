// WRITE with StreamWriter
using (StreamWriter sw = new StreamWriter("log.txt"))
{
    sw.WriteLine("Line 1");
    sw.WriteLine("Line 2");
    sw.WriteLine("Line 3");
}   // file automatically closed here — using handles it!

// READ with StreamReader
using (StreamReader sr = new StreamReader("log.txt"))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}