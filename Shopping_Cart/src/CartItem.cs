/*

Properties:
  Product  → Product
  Quantity → int

Constructor: takes Product + Quantity
Calculated property: Total → Product.Price * Quantity
ToString(): "Name x Qty = ₹Total"
*/

using System;

namespace Shopping_Cart.src
{
    class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        // Calculated property — computes when accessed
        public double Total => Product.Price * Quantity;

        public override string ToString() =>
            $"{Product.Name} x {Quantity} = ₹{Total:F2}";
    }
}