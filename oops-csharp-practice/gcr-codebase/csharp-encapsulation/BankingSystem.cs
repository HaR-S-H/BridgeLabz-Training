using System;

public interface ILoanable
{
    void ApplyForLoan();
    void CalculateLoanEligibility();
}

public abstract class BankAccount
{
    protected int accountNumber;
    protected double balance;
    protected string holderName;
    public BankAccount(int accountNumber, double balance, string holderName)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        this.holderName = holderName;
    }
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposit successful. New balance: " + balance);
    }
    public void Withdraw(double amount)
    {
        balance -= amount;
        Console.WriteLine("Withdrawal successful. New balance: " + balance);
    }
    public abstract void CalculateInterest();
}

class SavingAccount : BankAccount, ILoanable
{
    public SavingAccount(int accountNumber, double balance, string holderName) : base(accountNumber, balance, holderName)
    {

    }
    private readonly double interestRate = 0.05;
    public void ApplyForLoan()
    {
        Console.WriteLine("Loan applied successfully.");
    }
    public void CalculateLoanEligibility()
    {
        Random random = new Random();
        int eligibility = random.Next(0, 2);
        if (eligibility == 1)
            Console.WriteLine("Eligible for loan.");
        else
            Console.WriteLine("Not eligible for loan.");
    }
    public override void CalculateInterest()
    {
        Console.WriteLine("Interest : " + interestRate * balance);
    }
}

class CurrentAccount : BankAccount, ILoanable
{
    private readonly double interestRate = 0.01;
    public CurrentAccount(int accountNumber, double balance, string holderName) : base(accountNumber, balance, holderName)
    { }
    public void ApplyForLoan()
    {
        Console.WriteLine("Loan applied successfully.");
    }
    public void CalculateLoanEligibility()
    {
        Random random = new Random();
        int eligibility = random.Next(0, 2);
        if (eligibility == 1)
            Console.WriteLine("Eligible for loan.");
        else
            Console.WriteLine("Not eligible for loan.");
    }
    public override void CalculateInterest()
    {
        Console.WriteLine("Interest : " + interestRate * balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount currentAccount = new CurrentAccount(1, 1000, "harsh");
        BankAccount savingAccount = new SavingAccount(2, 2000, "harsh");
        currentAccount.CalculateInterest();
        savingAccount.CalculateInterest();
    }
}