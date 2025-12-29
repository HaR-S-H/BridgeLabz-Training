using System;
public class Employee
{
    private int id;
    private string name;
    private int salary;
    public Employee(int id, string name, int salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Employee details :- ");
        Console.WriteLine("Name :- " + name);
        Console.WriteLine("Id :- " + id);
        Console.WriteLine("Salary :- " + salary);
    }

}

public class program
{
    static void Main()
    {
        Employee employee1 = new Employee(1, "harsh", 1000);
        Employee employee2 = new Employee(2, "anoop", 1000);
        employee1.DisplayDetails();
        employee2.DisplayDetails();
    }
}