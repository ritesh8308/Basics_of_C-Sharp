/*

Exercise 4 — Contact Book
Use Dictionary<string, string> — name → phone number
Menu:
  1 → Add contact
  2 → Search contact by name
  3 → Delete contact
  4 → Save contacts to file
  5 → Load contacts from file
  6 → Exit

  
*/


using System;
using System.Collections.Generic;
using System.IO;
namespace Day_06
{
    class ContactBook
    {
        static Dictionary<string, string> contacts =
            new Dictionary<string, string>();
        const string FilePath = "contacts.txt";

        static void Main()
        {
            LoadContacts();

            while (true)
            {
                Console.WriteLine(new string('─', 30));
                Console.WriteLine("       Contact Book");
                Console.WriteLine(new string('─', 30));
                Console.WriteLine("  1 → Add contact");
                Console.WriteLine("  2 → Search contact");
                Console.WriteLine("  3 → Delete contact");
                Console.WriteLine("  4 → View all contacts");
                Console.WriteLine("  5 → Save to file");
                Console.WriteLine("  6 → Load from file");
                Console.WriteLine("  7 → Exit");
                Console.WriteLine(new string('─', 30));
                Console.Write("Choose: ");

                switch (Console.ReadLine())
                {
                    case "1": AddContact();    break;
                    case "2": SearchContact(); break;
                    case "3": DeleteContact(); break;
                    case "4": ViewAll();       break;
                    case "5": SaveContacts();  break;
                    case "6": LoadContacts();  break;
                    case "7":
                        SaveContacts();
                        Console.WriteLine("👋 Goodbye!");
                        return;
                    default:
                        Console.WriteLine("❌ Invalid option.");
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.Write("Enter name:  ");
            string name = Console.ReadLine().Trim();

            Console.Write("Enter phone: ");
            string phone = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("❌ Name and phone cannot be empty.");
                return;
            }

            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"⚠️  '{name}' already exists. Updating...");
            }

            contacts[name] = phone;
            Console.WriteLine($"✅ Contact saved: {name} → {phone}");
        }

        static void SearchContact()
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine().Trim();

            if (contacts.TryGetValue(name, out string phone))
                Console.WriteLine($"📞 {name} → {phone}");
            else
                Console.WriteLine($"❌ Contact '{name}' not found.");
        }

        static void DeleteContact()
        {
            Console.Write("Enter name to delete: ");
            string name = Console.ReadLine().Trim();

            if (contacts.Remove(name))
                Console.WriteLine($"🗑️  Deleted: {name}");
            else
                Console.WriteLine($"❌ Contact '{name}' not found.");
        }

        static void ViewAll()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("📭 No contacts saved.");
                return;
            }

            Console.WriteLine($"\n{"Name",-20} {"Phone",-15}");
            Console.WriteLine(new string('─', 35));
            foreach (var pair in contacts)
                Console.WriteLine($"  {pair.Key,-18} → {pair.Value}");
        }

        static void SaveContacts()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FilePath))
                {
                    foreach (var pair in contacts)
                        sw.WriteLine($"{pair.Key},{pair.Value}");
                }
                Console.WriteLine($"✅ Contacts saved to {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Save failed: {ex.Message}");
            }
        }

        static void LoadContacts()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("📭 No saved contacts file found.");
                return;
            }

            try
            {
                contacts.Clear();
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                        contacts[parts[0]] = parts[1];
                }
                Console.WriteLine($"✅ Loaded {contacts.Count} contact(s).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Load failed: {ex.Message}");
            }
        }
    }
}