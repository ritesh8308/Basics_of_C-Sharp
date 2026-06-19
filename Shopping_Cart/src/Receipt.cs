/*

Receipt.cs (namespace Shopping_Cart.src):

  Method:
    Generate(Cart cart, double discountPercent, string discountCode)
      → build the receipt text
      → calculate subtotal, discount amount, final total
      → print to console
      → SAVE to a file (receipt.txt)

  Use:
    → DateTime.Now for the date
    → StringBuilder to build the receipt text
    → File.WriteAllText to save it
    → LINQ for subtotal
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
namespace Shopping_Cart.src
{
    class Receipt
    {
        public static void Generate(Cart cart, double discountPercent,
                                     double flatDiscount, string discountCode)
        {
            if (cart.IsEmpty())
            {
                Console.WriteLine("Cannot generate receipt for empty cart.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("═══════════════════════════════════");
            sb.AppendLine("           SHOPPING RECEIPT");
            sb.AppendLine("═══════════════════════════════════");
            sb.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine("───────────────────────────────────");

            sb.AppendLine("Items:");
            foreach (var item in cart.Items)
            {
                sb.AppendLine($"  {item.Product.Name}");
                sb.AppendLine($"    Qty: {item.Quantity} x ₹{item.Product.Price:F2} = ₹{item.Total:F2}");
            }
            sb.AppendLine("───────────────────────────────────");

            double subtotal = cart.GetSubtotal();
            double discountAmount = 0;

            if (discountPercent > 0)
                discountAmount = subtotal * (discountPercent / 100.0);
            else if (flatDiscount > 0)
                discountAmount = flatDiscount;

            double finalTotal = Math.Max(0, subtotal - discountAmount);

            sb.AppendLine($"{"Subtotal:",-15} ₹{subtotal,10:F2}");

            if (discountPercent > 0)
            {
                sb.AppendLine($"{"Code:",-15} {discountCode}");
                sb.AppendLine($"Discount ({discountPercent}%):  -₹{discountAmount:F2}");
            }
            else if (flatDiscount > 0)
            {
                sb.AppendLine($"{"Code:",-15} {discountCode}");
                sb.AppendLine($"{"Flat Discount:",-15} -₹{discountAmount:F2}");
            }

            sb.AppendLine("═══════════════════════════════════");
            sb.AppendLine($"{"TOTAL:",-15} ₹{finalTotal,10:F2}");
            sb.AppendLine("═══════════════════════════════════");
            sb.AppendLine("     Thank you for shopping! 🎉");
            sb.AppendLine("═══════════════════════════════════");

            string receipt = sb.ToString();
            Console.WriteLine(receipt);

            try
            {
                File.WriteAllText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}.txt", receipt);
                Console.WriteLine($"Receipt saved to {DateTime.Now:yyyy-MM-dd HH:mm:ss}.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving receipt: {ex.Message}");
            }
        }
    }
}