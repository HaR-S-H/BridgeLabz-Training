using System;
using System.Collections.Generic;

// Interface
public interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// Abstract Base Class
public abstract class Employee : IDepartment
{
    // Encapsulated fields
    private int employeeId;
    private string name;
    private double baseSalary;
    private string department;

    // Properties (Encapsulation)
    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set
        {
            if (value > 0)
                baseSalary = value;
        }
    }

    // Constructor
    public Employee(int id, string name, double baseSalary)
    {
        EmployeeId = id;
        Name = name;
        BaseSalary = baseSalary;
    }

    // Interface Methods
    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }

    // Concrete method
    public void DisplayDetails()
    {
        Console.WriteLine("ID: " + EmployeeId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + GetDepartmentDetails());
        Console.WriteLine("Salary: ₹" + CalculateSalary());
        Console.WriteLine("----------------------------");
    }

    // Abstract method
    public abstract double CalculateSalary();
}

// Derived Class - Full Time Employee
public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double fixedSalary)
        : base(id, name, fixedSalary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary; // Fixed monthly salary
    }
}

// Derived Class - Part Time Employee
public class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private double ratePerHour;

    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
    {
        hoursWorked = hours;
        ratePerHour = rate;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * ratePerHour;
    }
}

// Program Class
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        Employee emp1 = new FullTimeEmployee(101, "Harsh", 50000);
        emp1.AssignDepartment("IT");

        Employee emp2 = new PartTimeEmployee(102, "Aman", 80, 300);
        emp2.AssignDepartment("HR");

        employees.Add(emp1);
        employees.Add(emp2);

        // Polymorphism in action
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
