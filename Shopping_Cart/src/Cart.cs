/*

Cart.cs (namespace Shopping_Cart.src):

  Property:
    List<CartItem> Items   → the cart contents

  Methods:
    AddItem(Product product, int quantity)
      → if product already in cart, increase quantity
      → else add new CartItem

    RemoveItem(int productId)
      → remove item matching that product Id

    GetSubtotal()
      → LINQ: Items.Sum(i => i.Total)

    ViewCart()
      → print all items + subtotal
      → handle empty cart

    IsEmpty()
      → return Items.Count == 0
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Cart.src
{
    class Cart
    {
        public List<CartItem> Items { get; }

        public Cart()
        {
            Items = new List<CartItem>();
        }

        //AddItem() :
        public void AddItem(Product product, int quantity)
        {
            var existingItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);

            if(existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem(product, quantity));
            }
        }



        //RemoveItem() :
        public void RemoveItem(int productId)
        {
            var item = Items.FirstOrDefault(i => i.Product.Id == productId);
            if(item != null)
            {
                Items.Remove(item);
                Console.WriteLine($"Removed: {item.Product.Name}");
            }
            else
            {
                Console.WriteLine("Item not found in cart.");
            }
        }



        //GetSubtotal() :
        public double GetSubtotal()
        {
            return Items.Sum(i => i.Total);
        }



        //ViewCart() :
        public void ViewCart()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            Console.WriteLine("\n--- Cart Contents ---");
            foreach(var item in Items)
            {
                Console.WriteLine($"{item.Product.Name} X {item.Quantity} = Rs.{item.Total:F2}");
            }
            Console.WriteLine($"Subtotal: Rs.{GetSubtotal():F2}");
        }

        public bool IsEmpty()
        {
            return Items.Count == 0;
        }
    }
}