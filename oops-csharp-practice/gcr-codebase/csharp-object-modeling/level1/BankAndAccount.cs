using System;
class Bank
{
    //static variable
    public string bankName;
    public Bank(string bankName) //parameterized constructor
    {
        this.bankName = bankName;
    }
    public void OpenAccount(Customer customer,double balance)
    {
        customer.balance = balance;
        customer.bank = this;
        Console.WriteLine("Account opened for customer : " + customer.name);
    }


}
class Customer
{   //instance variable
    public string name;
    public Bank bank;
    public int age;
    public double balance;

    public Customer(string name, int age) //parameterized customer
    {
        this.name = name;
        this.age = age;

    }
    public void ViewBalance() //methood for view balance
    {
        if (bank != null)
            Console.WriteLine("Your balance is " + balance);
        else
            Console.WriteLine("No bank found");
    }


}
class Program
{   //entry point
    static void Main()
    {
        Bank bank = new Bank("SBI");
        Customer customer = new Customer("Ujjwal", 21);
        bank.OpenAccount(customer, 1000);
        customer.ViewBalance();
    }
}