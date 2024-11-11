namespace ConsoleApp;

public class Wallet(double initialAmount)
{
    public double Amount { get; set; } = initialAmount;

    public double Withdraw(double amount)
    {
        if (amount <= 0 || amount > Amount)
        {
            throw new ArgumentException("Invalid withdrawal amount.");
        }
        
        return Amount -= amount; 
    }
    
}