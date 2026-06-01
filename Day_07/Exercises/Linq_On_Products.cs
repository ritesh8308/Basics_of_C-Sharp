/*

Exercise 2 — LINQ on Products
Create a List of at least 8 products
(Name, Price, Category)

Use LINQ to:
  → Filter products under ₹1000
  → Sort by price ascending
  → Get all Electronics
  → Most expensive product
  → Average price per category (GroupBy)
  → All product names as uppercase
  → Count per category
Print all results neatly
*/


using System;
using System.Collections.Generic;
using System.Linq;
namespace Day_07
{
    class Product
    {
        public string Name     { get; set; }
        public double Price    { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string category)
        {
            Name = name; Price = price; Category = category;
        }

        public override string ToString() =>
            $"{Name,-20} ₹{Price,-10:F2} {Category}";
    }

    class Program
    {
        static void PrintSection(string title)
        {
            Console.WriteLine(new string('─', 50));
            Console.WriteLine($"  📦 {title}");
            Console.WriteLine(new string('─', 50));
        }

        static void Main()
        {
            var products = new List<Product>
            {
                new Product("Laptop",     79999, "Electronics"),
                new Product("Mouse",        499, "Electronics"),
                new Product("Keyboard",     899, "Electronics"),
                new Product("Monitor",    12999, "Electronics"),
                new Product("Notebook",     299, "Stationery"),
                new Product("Pen",           49, "Stationery"),
                new Product("Book",         599, "Books"),
                new Product("Headphones",  4999, "Electronics")
            };

            // Filter under ₹1000
            PrintSection("Products under ₹1000");
            products.Where(p => p.Price < 1000)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"  {p}"));

            // Sort by price ascending
            PrintSection("All Products — Price Ascending");
            products.OrderBy(p => p.Price)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"  {p}"));

            // Electronics only
            PrintSection("Electronics");
            products.Where(p => p.Category == "Electronics")
                    .ToList()
                    .ForEach(p => Console.WriteLine($"  {p}"));

            // Most expensive
            PrintSection("Most Expensive Product");
            Console.WriteLine($"  {products.OrderByDescending(p => p.Price).First()}");

            // Average price per category
            PrintSection("Average Price per Category");
            products.GroupBy(p => p.Category)
                    .Select(g => new
                    {
                        Category = g.Key,
                        AvgPrice = g.Average(p => p.Price)
                    })
                    .ToList()
                    .ForEach(x => Console.WriteLine($"  {x.Category,-15} ₹{x.AvgPrice:F2}"));

            // Names uppercase
            PrintSection("All Product Names (Uppercase)");
            products.Select(p => p.Name.ToUpper())
                    .ToList()
                    .ForEach(n => Console.WriteLine($"  {n}"));

            // Count per category
            PrintSection("Count per Category");
            products.GroupBy(p => p.Category)
                    .Select(g => new
                    {
                        Category = g.Key,
                        Count = g.Count()
                    })
                    .ToList()
                    .ForEach(x => Console.WriteLine($"  {x.Category,-15} {x.Count} products"));

            Console.WriteLine(new string('─', 50));
        }
    }
}