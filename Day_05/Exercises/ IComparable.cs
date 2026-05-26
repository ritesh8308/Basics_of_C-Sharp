/*
Exercise 3 — Interface: IComparable on Product
Interface: IProduct
  → string GetDescription()
  → double GetPrice()

Class: Product implements IProduct
  → Properties: Name, Price, Category
  → Constructor: takes all three
  → GetDescription() → "Name (Category)"
  → GetPrice()       → return Price
  → Bonus: implement IComparable<Product>
    → CompareTo() — compare by price
    → Then sort an array of products by price
*/

using System;
namespace Day_05
{
    interface IProduct
    {
        string GetDescription();
        double GetPrice();
    }

    class Product : IProduct, IComparable<Product>
    {
        public string Name     { get; set; }
        public double Price    { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string category)
        {
            Name     = name;
            Price    = price;
            Category = category;
        }

        public string GetDescription()
        {
            return $"{Name} ({Category})";
        }

        public double GetPrice()
        {
            return Price;
        }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{"Product:",-12} {GetDescription()}");
            Console.WriteLine($"{"Price:",-12} ₹{GetPrice():F2}");
        }
    }

    class Program
    {
        static void Main()
        {
            Product[] products = {
                new Product("iPhone 15",       79999, "Electronics"),
                new Product("Notebook",           299, "Stationery"),
                new Product("Sony Headphones",   4999, "Electronics"),
                new Product("Pen",                 49, "Stationery")
            };

            // Before sort
            Console.WriteLine("===== Before Sorting =====");
            foreach (Product p in products)
                Console.WriteLine($"{p.GetDescription(),-30} ₹{p.GetPrice():F2}");

            // Sort by price
            Array.Sort(products);

            // After sort
            Console.WriteLine("\n===== After Sorting (by Price) =====");
            foreach (Product p in products)
                Console.WriteLine($"{p.GetDescription(),-30} ₹{p.GetPrice():F2}");
        }
    }
}