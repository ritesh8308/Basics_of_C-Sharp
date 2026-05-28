// Without try/catch — program CRASHES on error
int result = 10 / 0;   // DivideByZeroException → crash!

// With try/catch — program HANDLES the error gracefully
try
{
    int result = 10 / 0;   // error happens here
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Math error: {ex.Message}");
}
catch (Exception ex)          // catches ANY other exception
{
    Console.WriteLine($"Something went wrong: {ex.Message}");
}
finally
{
    // ALWAYS runs — whether error happened or not
    Console.WriteLine("Done — cleanup here.");
}