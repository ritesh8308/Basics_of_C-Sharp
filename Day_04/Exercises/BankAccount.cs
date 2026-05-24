/**

Exercise 1 — BankAccount Class 🏦
Create a class BankAccount with:

Properties:
  Owner   → string  (public)
  Balance → double  (private — only exposed via GetBalance())

Constructor:
  Takes owner name
  Sets balance to 0

Methods:
  Deposit(amount)   → add to balance
                    → reject if amount <= 0
  Withdraw(amount)  → deduct from balance
                    → reject if amount <= 0
                    → reject if amount > balance
  GetBalance()      → return current balance
  PrintStatement()  → print owner name + balance formatted

Bonus:
  Track total number of transactions (deposits + withdrawals)
  Print transaction count in PrintStatement()


  
Expected Output:
Owner:        Ritesh
Balance:      ₹1500.00
Transactions: 3
*/



using System;
namespace Day_04
{
    public class BankAccount
    {
        private double balance;
        public string Owner { get; set; }
        public int TotalTransactions { get; private set; }

        public BankAccount(string owner)
        {
            Owner   = owner;
            balance = 0.00;
            TotalTransactions = 0;
        }

        public void Deposit(double amt)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Invalid deposit amount!");
                return;
            }
            balance += amt;
            TotalTransactions++;
        }

        public void Withdraw(double amt)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Amount must be positive!");
                return;
            }
            if (amt > balance)
            {
                Console.WriteLine("Insufficient balance!");
                return;
            }
            balance -= amt;
            TotalTransactions++;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void PrintStatement()
        {
            Console.WriteLine("======= Bank Statement =======");
            Console.WriteLine($"{"Owner:",-15} {Owner}");
            Console.WriteLine($"{"Balance:",-15} {balance:F2}");
            Console.WriteLine($"{"Transactions:",-15} {TotalTransactions}");
            Console.WriteLine("==============================");
        }

        static void Main()
        {
            BankAccount b1 = new BankAccount("Ritesh");

            b1.Deposit(1585.15);
            b1.Withdraw(500.23);
            b1.Deposit(200.00);

            b1.PrintStatement();

            // Test invalid cases
            b1.Deposit(-100);
            b1.Withdraw(99999);
        }
    }
}