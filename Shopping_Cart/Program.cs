using System;
using System.Collections.Generic;
using System.Linq;
using Shopping_Cart.src;

namespace Shopping_Cart
{
    class Program
    {
        static void Main()
        {
            var inventory = new List<Product>
            {
                new Product(1, "Laptop",      79999, "Electronics", 5),
                new Product(2, "Mouse",         499, "Electronics", 20),
                new Product(3, "Keyboard",      899, "Electronics", 15),
                new Product(4, "Monitor",     12999, "Electronics", 8),
                new Product(5, "Notebook",      299, "Stationery",  50),
                new Product(6, "Pen",            49, "Stationery",  100),
                new Product(7, "Book",          599, "Books",       30),
                new Product(8, "Headphones",   4999, "Electronics", 10),
                new Product(9, "Desk Lamp",    1299, "Furniture",   12),
                new Product(10,"USB Cable",     199, "Electronics", 40)
            };

            // value < 1 = percentage, value >= 1 = flat amount
            var discountCodes = new Dictionary<string, double>
            {
                { "SAVE10",   10 },    // 10%
                { "SAVE20",   20 },    // 20%
                { "WELCOME5",  5 },    // 5%
                { "FLAT500",  500 }    // ₹500 flat (handled separately)
            };

            var cart = new Cart();
            double appliedPercent = 0;
            double appliedFlat = 0;
            string appliedCode = "";

            while (true)
            {
                Console.WriteLine("\n═══════════════════════════════════");
                Console.WriteLine("       SHOPPING CART MENU");
                Console.WriteLine("═══════════════════════════════════");
                Console.WriteLine("1 → Browse products by category");
                Console.WriteLine("2 → Add product to cart");
                Console.WriteLine("3 → View cart");
                Console.WriteLine("4 → Remove item from cart");
                Console.WriteLine("5 → Apply discount code");
                Console.WriteLine("6 → Checkout");
                Console.WriteLine("7 → Exit");
                Console.WriteLine("═══════════════════════════════════");
                Console.Write("Choose option: ");

                switch (Console.ReadLine())
                {
                    case "1": BrowseByCategory(inventory); break;
                    case "2": AddToCart(cart, inventory);  break;
                    case "3": cart.ViewCart();             break;
                    case "4": RemoveFromCart(cart);        break;
                    case "5": ApplyDiscount(discountCodes,
                                  ref appliedPercent, ref appliedFlat, ref appliedCode);
                              break;
                    case "6":
                        Receipt.Generate(cart, appliedPercent, appliedFlat, appliedCode);
                        cart = new Cart();
                        appliedPercent = 0;
                        appliedFlat = 0;
                        appliedCode = "";
                        break;
                    case "7":
                        Console.WriteLine("Thank you for shopping!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void BrowseByCategory(List<Product> inventory)
        {
            Console.WriteLine("\nCategories:");
            foreach (var cat in inventory.Select(p => p.Category).Distinct())
                Console.WriteLine($"  - {cat}");

            Console.Write("Enter category: ");
            string category = Console.ReadLine() ?? "";


            var products = inventory
                .Where(p => p.Category.ToLower() == category.ToLower())
                .ToList();

            if (products.Count == 0)
            {
                Console.WriteLine("No products in this category.");
                return;
            }

            Console.WriteLine($"\nProducts in {category}:");
            foreach (var p in products)
                Console.WriteLine($"  ID:{p.Id,-3} {p.Name,-15} Rs.{p.Price:F2}");
        }

        static void AddToCart(Cart cart, List<Product> inventory)
        {
            Console.Write("Enter Product ID: ");
            if (!int.TryParse(Console.ReadLine(), out int productId))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var product = inventory.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            cart.AddItem(product, quantity);
        }

        static void RemoveFromCart(Cart cart)
        {
            if (cart.IsEmpty())
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            Console.Write("Enter Product ID to remove: ");
            if (!int.TryParse(Console.ReadLine(), out int productId))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            cart.RemoveItem(productId);
        }

        static void ApplyDiscount(Dictionary<string, double> codes,
            ref double appliedPercent, ref double appliedFlat, ref string appliedCode)
        {
            Console.Write("Enter discount code: ");
            string code = (Console.ReadLine() ?? "").ToUpper();

            if (codes.TryGetValue(code, out double value))
            {
                if (value >= 100)         // flat amount (500)
                {
                    appliedFlat = value;
                    appliedPercent = 0;
                }
                else                      // percentage (5, 10, 20)
                {
                    appliedPercent = value;
                    appliedFlat = 0;
                }
                appliedCode = code;
                Console.WriteLine($"✅ Code '{code}' applied!");
            }
            else
            {
                Console.WriteLine("❌ Invalid discount code.");
            }
        }
    }
}