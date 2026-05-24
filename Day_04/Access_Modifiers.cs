class BankAccount
{
    private double balance;      // only THIS class can access
    public string Owner { get; set; }  // anyone can access
    protected double limit;      // this class + child classes
    internal string branch;      // accessible within same project

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be positive!");
            return;
        }
        balance += amount;       // private field accessed inside class ✅
    }

    public double GetBalance()
    {
        return balance;          // expose private data safely
    }
}

// Outside the class
BankAccount acc = new BankAccount();
acc.Deposit(1000);              // ✅ public method
Console.WriteLine(acc.GetBalance()); // ✅ public method
// acc.balance = 9999;          // ❌ private — won't compile