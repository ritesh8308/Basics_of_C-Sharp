/*

Exercise 1 — LINQ on Students
Create a List of at least 6 students
(Name, Age, Grade, City)

Use LINQ to:
  → Find all students with Grade >= 75
  → Sort all students by Grade descending
  → Get names of students from "Mumbai"
  → Find the student with highest grade
  → Calculate average grade
  → Count students who are passing (>= 40)
  → Group students by city
  → Get top 3 students
Print all results neatly
*/

using System;
using System.Collections.Generic;
using System.Linq;
namespace Day_07
{
    class Student
    {
        public string Name  { get; set; }
        public int Age      { get; set; }
        public double Grade { get; set; }
        public string City  { get; set; }

        public Student(string name, int age, double grade, string city)
        {
            Name = name; Age = age; Grade = grade; City = city;
        }

        public override string ToString() =>
            $"{Name,-10} Age:{Age}  Grade:{Grade:F1}  City:{City}";
    }

    class Program
    {
        static void PrintSection(string title)
        {
            Console.WriteLine(new string('─', 45));
            Console.WriteLine($"  {title}");
            Console.WriteLine(new string('─', 45));
        }

        static void Main()
        {
            var students = new List<Student>
            {
                new Student("Asha",  20, 88.5, "Mumbai"),
                new Student("Rajat", 22, 74.0, "Delhi"),
                new Student("Neha",  19, 91.0, "Mumbai"),
                new Student("Siddh", 21, 39.5, "Kolkata"),
                new Student("Priya", 23, 65.0, "Pune"),
                new Student("Arun",  20, 82.0, "Mumbai"),
                new Student("Meera", 18, 47.0, "Pune")
            };

            // Grade >= 75
            PrintSection("Students with Grade >= 75");
            students.Where(s => s.Grade >= 75)
                    .ToList()
                    .ForEach(s => Console.WriteLine($"  {s}"));

            // Sort by grade desc
            PrintSection("All Students — Sorted by Grade (desc)");
            students.OrderByDescending(s => s.Grade)
                    .ToList()
                    .ForEach(s => Console.WriteLine($"  {s}"));

            // Mumbai students
            PrintSection("Students from Mumbai");
            students.Where(s => s.City == "Mumbai")
                    .Select(s => s.Name)
                    .ToList()
                    .ForEach(n => Console.WriteLine($"  {n}"));

            // Top student — MaxBy is cleaner : var top = students.MaxBy(s => s.Grade);
            PrintSection("Top Student");
            var top = students.OrderByDescending(s => s.Grade).First();
            Console.WriteLine($"  {top}");

            // Average grade
            PrintSection("Average Grade");
            Console.WriteLine($"  {students.Average(s => s.Grade):F2}");

            // Passing count
            PrintSection("Passing Students (Grade >= 40)");
            Console.WriteLine($"  {students.Count(s => s.Grade >= 40)} students");

            // Group by city
            PrintSection("Grouped by City");
            foreach (var group in students.GroupBy(s => s.City))
            {
                Console.WriteLine($"  {group.Key} ({group.Count()} students):");
                foreach (var s in group)
                    Console.WriteLine($"    → {s.Name} — Grade:{s.Grade:F1}");
            }

            // Top 3
            PrintSection("Top 3 Students");
            var top3 = students.OrderByDescending(s => s.Grade).Take(3).ToList();
            for (int i = 0; i < top3.Count; i++)
                Console.WriteLine($"  {i + 1}. {top3[i].Name,-10} Grade:{top3[i].Grade:F1}");

            Console.WriteLine(new string('─', 45));
        }
    }
}