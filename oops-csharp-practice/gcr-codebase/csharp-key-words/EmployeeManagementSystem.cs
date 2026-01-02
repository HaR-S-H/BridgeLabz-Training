using System;
class Employee
{ //class variable
    public static string companyName = "Google";
    private static int totalEmployees = 0;
    public string name;
    public readonly int Id;
    public string designation;
    public Employee(string name, int Id, string designation) //parameterized constructor
    {
        this.name = name;
        this.Id = Id;
        this.designation = designation;
        totalEmployees++; //incrementing total number of employees
    }

    public static int DisplayTotalEmployees() //static method to know total number of employees
    {
        return totalEmployees;
    }
    public void DisplayDetails() //method to display employee details
    {
        Console.WriteLine("Name :- " + name);
        Console.WriteLine("Id :- " + Id);
        Console.WriteLine("Designation :- " + designation);
    }

}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("harsh", 1, "IT"); //object creation
        employee.DisplayDetails(); //calling method
        Console.WriteLine("Total number of employees :- " + Employee.DisplayTotalEmployees());
    }
}