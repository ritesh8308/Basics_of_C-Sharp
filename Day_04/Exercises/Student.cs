/*

Exercise 2 — Student Class 🎓
Create a class Student with:

Properties:
  Name   → string
  Age    → int
  Grades → double[] (private)

Constructor:
  Takes name, age, and grades array

Methods:
  GetAverage()     → calculate & return average of grades
  GetGradeLetter() → return A/B/C/D/F based on average
  GetHighest()     → return highest grade (no Math.Max)
  GetLowest()      → return lowest grade  (no Math.Min)
  PrintReport()    → print full student report card

Bonus:
  IsPassing()      → return true if average >= 40




  
Expected Output:
======= Report Card =======
Name:    Ritesh Mane
Age:     22
Average: 87.60
Grade:   B
Highest: 95.00
Lowest:  78.00
Result:  Pass ✅
===========================
*/

using System;
namespace Day_04
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private double[] grades;

        public Student(string name, int age, double[] grades)
        {
            this.Name   = name;
            this.Age    = age;
            this.grades = grades;
        }

        public double GetAverage()
        {
            double sum = 0;
            foreach (double g in grades)
                sum += g;
            return sum / grades.Length;
        }

        public string GetGradeLetter()
        {
            double avg = GetAverage();
            if (avg >= 90) return "A";
            if (avg >= 75) return "B";
            if (avg >= 60) return "C";
            if (avg >= 40) return "D";
            return "F";
        }

        public double GetHighest()
        {
            double high = double.MinValue;
            foreach (double g in grades)
                if (g > high) high = g;
            return high;
        }

        public double GetLowest()
        {
            double low = double.MaxValue;
            foreach (double g in grades)
                if (g < low) low = g;
            return low;
        }

        public bool IsPassing()
        {
            return GetAverage() >= 40;
        }

        public void PrintReport()
        {
            Console.WriteLine("======= Report Card =======");
            Console.WriteLine($"{"Name:",-10} {Name}");
            Console.WriteLine($"{"Age:",-10} {Age}");
            Console.WriteLine($"{"Average:",-10} {GetAverage():F2}");
            Console.WriteLine($"{"Grade:",-10} {GetGradeLetter()}");
            Console.WriteLine($"{"Highest:",-10} {GetHighest():F2}");
            Console.WriteLine($"{"Lowest:",-10} {GetLowest():F2}");
            Console.WriteLine($"{"Result:",-10} {(IsPassing() ? "Pass ✅" : "Fail ❌")}");
            Console.WriteLine("===========================");
        }

        static void Main()
        {
            double[] grades = { 85, 92, 78, 95, 88 };
            Student s = new Student("Ritesh Mane", 22, grades);
            s.PrintReport();
        }
    }
}