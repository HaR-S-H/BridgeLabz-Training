using System;
class Employee
{ //instance variables
    public int employeeID;
    protected string department;
    private double salary;
    public Employee(int employeeID, string department) //parameterized constructor
    {
        this.employeeID = employeeID;
        this.department = department;
    }
    public void SetSalary(double salary) //methods to set salary
    {
        this.salary = salary;
    }
    public double GetSalary() //method to get salary
    {
        return salary;
    }
}
class Manager : Employee
{
    public Manager(int employeeID, string department, double salary) :base(employeeID, department) //parameterized constructor
    {
        SetSalary(salary);
    }
    public void DisplayDetails() //method to display details
    {
        Console.WriteLine("Employee ID :- " + employeeID);
        Console.WriteLine("Department :- " + department);
        Console.WriteLine("Salary :- " + GetSalary());
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "IT", 50000); //object creation
        manager.DisplayDetails();
    }
}