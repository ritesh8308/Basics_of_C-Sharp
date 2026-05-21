using System;

namespace Day_02
{

    class Loops
    {
        static void Main(string[] args)
        {
            
//        #1 : for — when you know how many times 
        // for (start; condition; step)
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Count: {i}");
        }
        // Count: 1
        // Count: 2 ... Count: 5

        // Counting backwards
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(i);
        }






//      #2 : while — when you don't know how many times
        Console.Write("Enter a positive number: ");
        int num = int.Parse(Console.ReadLine());

        while (num <= 0)
        {
            Console.WriteLine("Must be positive! Try again.");
            Console.Write("Enter a positive number: ");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"You entered: {num}");






//     #3 : do-while — always runs at least once

/**

One danger — infinite loop ⚠️
If the correct password is never typed, this loop never ends. 
In real apps you'd add a max attempts limit: 3 maxAttempts

**/
            string password;
            int attempts = 0;
            int maxAttempts = 3;

            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                attempts++;

                if (attempts < maxAttempts && password != "csharp123")
                    Console.WriteLine($"Wrong! {maxAttempts - attempts} attempts left.");
            }
            while (password != "csharp123" && attempts < maxAttempts);

            if (password == "csharp123")
                Console.WriteLine("Access granted!");
            else
                Console.WriteLine("Too many failed attempts. Locked out!");







//          #4 : break and continue

            // break — exits the loop completely
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) break;          // stops at 5
                Console.WriteLine(i);        // prints 1 2 3 4
            }

            // continue — skips current iteration, goes to next
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) continue;   // skip even numbers
                Console.WriteLine(i);        // prints 1 3 5 7 9
            }


          /*

          🔑 Quick Reference:

               Loop                 Use when

              1) for              You know the count (print 1–100, table of 5)
              2)while            Keep going until condition is false (user input, game loop)
              3) do-while         Must run at least once (menu, password prompt)  

              */
        }
    }
}