/**

Exercise 3 — Safe File Reader
Ask user for a file path
Use try/catch to handle:
  → FileNotFoundException (file doesn't exist)
  → UnauthorizedAccessException (no permission)
  → Any other exception
If file exists: print line count + first 5 lines
Bonus: write a summary to a new output file

*/


using System;
using System.IO;
namespace Day_06
{
    class SafetyReader
    {
        static void Main()
        {
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("❌ No path entered!");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(path);

                Console.WriteLine($"\n📄 File:       {path}");
                Console.WriteLine($"📊 Line count: {lines.Length}");
                Console.WriteLine("\n📋 First 5 lines:");
                Console.WriteLine(new string('─', 30));

                for (int i = 0; i < Math.Min(5, lines.Length); i++)
                    Console.WriteLine($"  {i + 1}. {lines[i]}");

                // Bonus — write summary file
                string summaryPath =
                    Path.GetFileNameWithoutExtension(path) + "_summary.txt";

                using (StreamWriter sw = new StreamWriter(summaryPath))
                {
                    sw.WriteLine($"File:       {path}");
                    sw.WriteLine($"Line count: {lines.Length}");
                    sw.WriteLine("First 5 lines:");
                    for (int i = 0; i < Math.Min(5, lines.Length); i++)
                        sw.WriteLine($"  {i + 1}. {lines[i]}");
                }

                Console.WriteLine($"\n✅ Summary written to: {summaryPath}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("❌ Error: File not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("❌ Error: No permission to access this file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Unexpected error: {ex.Message}");
            }
        }
    }
}