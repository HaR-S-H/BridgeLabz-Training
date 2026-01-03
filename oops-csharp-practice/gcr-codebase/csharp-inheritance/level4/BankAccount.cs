using System;

// Base class: BankAccount
class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, double balance)
    {
        this.AccountNumber = accountNumber;
        this.Balance = balance;
    }

    // Virtual method to display account type (to be overridden)
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("General Bank Account");
    }

    // Method to display basic account info
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: ${Balance}");
    }
}

// Subclass: SavingsAccount
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; } // in percentage

    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        this.InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}

// Subclass: CheckingAccount
class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        this.WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine($"Withdrawal Limit: ${WithdrawalLimit}");
    }
}

// Subclass: FixedDepositAccount
class FixedDepositAccount : BankAccount
{
    public int DurationInMonths { get; set; } // e.g., 12 months, 24 months

    public FixedDepositAccount(int accountNumber, double balance, int durationInMonths)
        : base(accountNumber, balance)
    {
        this.DurationInMonths = durationInMonths;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine($"Duration: {DurationInMonths} months");
    }
}

// Test program
class Program
{
    static void Main()
    {
        // Savings account
        SavingsAccount sa = new SavingsAccount(101, 5000, 4.5);
        sa.DisplayAccountInfo();
        sa.DisplayAccountType();
        Console.WriteLine();

        // Checking account
        CheckingAccount ca = new CheckingAccount(102, 3000, 1000);
        ca.DisplayAccountInfo();
        ca.DisplayAccountType();
        Console.WriteLine();

        // Fixed deposit account
        FixedDepositAccount fda = new FixedDepositAccount(103, 10000, 12);
        fda.DisplayAccountInfo();
        fda.DisplayAccountType();
    }
}
