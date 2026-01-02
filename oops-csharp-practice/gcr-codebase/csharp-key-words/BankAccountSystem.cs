using System;
class BankAccount
{   //class variables
    public static string bankName = "ICICI Bank";
    private static int totalAccounts = 0;
    //instance variables
    public string accountHolderName;
    public readonly int AccountNumber;
    public BankAccount(string accountHolderName, int AccountNumber) //parameterized constructor
    {
        this.accountHolderName = accountHolderName;
        this.AccountNumber = AccountNumber;
        totalAccounts++;
    }
    public static int GetTotalAccounts() //a static method to know total number of accounts
    {
        return totalAccounts;
    }
    public void DisplayDetails() //method to display account details
    {
        Console.WriteLine("Bank Name :- " + bankName);
        Console.WriteLine("Account Holder Name :- " + accountHolderName);
        Console.WriteLine("Account Number :- " + AccountNumber);
    }

}
class Program
{   //entry point
    static void Main()
    {
        BankAccount account = new BankAccount("harsh", 1); //object creation
        if(account is BankAccount) //checking type of object
        account.DisplayDetails(); //calling method
    }
}