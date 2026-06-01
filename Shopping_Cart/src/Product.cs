/*

Properties:
  Id       → int
  Name     → string
  Price    → double
  Category → string
  Stock    → int

Constructor: takes all 5 (in order: id, name, price, category, stock)
ToString(): "Name | ₹Price | Category | Stock: n"
*/

using System;

namespace Shopping_Cart.src
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, double price, string category, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            Stock = stock;

        }

        public override string ToString() =>
            $"ID:{Id} | {Name} | ₹{Price:F2} | {Category} | Stock: {Stock}";
    }
}