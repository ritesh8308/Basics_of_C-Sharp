/*
Exercise 1 — To-Do List App
Use List<string> to store tasks
Menu loop:
  1 → Add task
  2 → View all tasks (numbered)
  3 → Remove task by number
  4 → Exit
Handle invalid input gracefully
*/


using System;
using System.Collections.Generic;
namespace Day_06
{
    class ToDoList
    {
        static void Main()
        {
            List<string> tasks = new List<string>();

            while (true)
            {
                Console.WriteLine(new string('─', 30));
                Console.WriteLine("       To-Do List Menu");
                Console.WriteLine(new string('─', 30));
                Console.WriteLine("  1 → Add task");
                Console.WriteLine("  2 → View all tasks");
                Console.WriteLine("  3 → Remove task");
                Console.WriteLine("  4 → Exit");
                Console.WriteLine(new string('─', 30));
                Console.Write("Choose: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter task: ");
                        string task = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(task))
                        {
                            tasks.Add(task);
                            Console.WriteLine("✅ Task added.");
                        }
                        else
                            Console.WriteLine("❌ Task cannot be empty.");
                        break;

                    case "2":
                        if (tasks.Count == 0)
                            Console.WriteLine("📭 No tasks found.");
                        else
                        {
                            Console.WriteLine("\n📋 Your tasks:");
                            for (int i = 0; i < tasks.Count; i++)
                                Console.WriteLine($"  {i + 1}. {tasks[i]}");
                        }
                        break;

                    case "3":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("📭 No tasks to remove.");
                            break;
                        }
                        Console.Write("Enter task number to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int num)
                            && num >= 1 && num <= tasks.Count)
                        {
                            Console.WriteLine($"🗑️  Removed: {tasks[num - 1]}");
                            tasks.RemoveAt(num - 1);
                        }
                        else
                            Console.WriteLine("❌ Invalid task number.");
                        break;

                    case "4":
                        Console.WriteLine("👋 Goodbye!");
                        return;

                    default:
                        Console.WriteLine("❌ Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}