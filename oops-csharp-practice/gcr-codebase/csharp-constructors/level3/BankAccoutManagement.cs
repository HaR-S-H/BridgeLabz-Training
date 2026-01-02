using System;
class BankAccount
{   //instance variable
    public int accountNumber;
    protected string accountHolder;
    private double balance;
    public BankAccount(int accountNumber, string accountHolder) //parameterized constructor
    {
        this.accountHolder = accountHolder;
        this.accountNumber = accountNumber;
    }
    public double GetBalance() { return balance; } //method to get balance
    public void SetBalance(double balance) { this.balance = balance; } //method to set balance

}

class SavingsAccount : BankAccount
{

    public SavingsAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder) //parameterized constructor
    {
        SetBalance(balance); //calling setBalance method of parent class
    }
    public void DisplayDetails() //method to display account details
    {
        Console.WriteLine("Account Number :" + accountNumber);
        Console.WriteLine("Account Holder Name :" + accountHolder);
        Console.WriteLine("Account Balance :" + GetBalance());
    }
}
class Program
{   //entry point
    static void Main()
    {
        SavingsAccount savingsAccount = new SavingsAccount(1, "harsh", 1000); //object creation
        savingsAccount.DisplayDetails(); //calling method to show details of savings account
    }
}
