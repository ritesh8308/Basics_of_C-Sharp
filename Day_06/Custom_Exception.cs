/*

// DivideByZeroException — dividing by zero
// FormatException       — int.Parse("abc")
// IndexOutOfRangeException — arr[99] on arr of size 5
// NullReferenceException   — calling method on null object
// FileNotFoundException    — file doesn't exist
// OverflowException        — number too large for type

*/




// Create your own exception type
class InsufficientFundsException : Exception
{
    public double Amount { get; }

    public InsufficientFundsException(double amount)
        : base($"Insufficient funds! Tried to withdraw {amount:F2}")
    {
        Amount = amount;
    }
}

// Throw it
public void Withdraw(double amount)
{
    if (amount > balance)
        throw new InsufficientFundsException(amount);
    balance -= amount;
}

// Catch it
try
{
    account.Withdraw(99999);
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine(ex.Message);   // Insufficient funds! Tried to withdraw 99999.00
}