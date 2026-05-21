/*

Program picks a random number between 1–100
User keeps guessing until correct
After each guess → print "Too High" or "Too Low"
At the end → print how many attempts it took

Hint: Random rng = new Random();
      int secret = rng.Next(1, 101);

*/

using System;
namespace Day_02
{
    class Guess
    {
        static void Main()
        {
            Random rng = new Random();
            int secret = rng.Next(1, 101);
            int attempts = 0;
            int guess;

            do
            {
                Console.Write("Enter your guess (1-100): ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input! Enter a number.");
                    continue;    // skip the rest, ask again
                }

                attempts++;

                if (guess < secret)
                    Console.WriteLine("Too Low!");
                else if (guess > secret)
                    Console.WriteLine("Too High!");

            }
            while (guess != secret);

            Console.WriteLine($"\nHooray! You Won! 🎉");
            Console.WriteLine($"The number was: {secret}");
            Console.WriteLine($"You took {attempts} attempts");
        }
    }
}