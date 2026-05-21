/*

Ask user for marks (0–100)
Print grade: A / B / C / D / F
Also print: Pass or Fail
Bonus: handle marks outside 0-100

*/

using System;

namespace Day_02
{
    class Grades
    {
        static void Main(string[] args)
        {
            int marks;
            Console.Write("Enter marks Obtained(0-100): ");

            while(true) {
            if(!int.TryPrase(Console.ReadLine(), out int marks)) 
            {
                Console.WriteLine("Enter valid marks");
                countinue;
            }

            break;

            }

            if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F — Failed");
            }

        }
    }
}