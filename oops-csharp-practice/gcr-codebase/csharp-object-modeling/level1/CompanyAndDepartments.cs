using System;
using System.Collections.Generic;
class Company
{ //instance variables
    public string name;
    public List<Department> departments; //list to store objects for departments
    public Company(string name) //parameterized constructor
    {
        this.name = name;
        departments = new List<Department>();
    }
    public void AddDepartment(Department department) //method to add department
    {
        departments.Add(department);
    }
    ~Company() //destructor
    {
        Console.WriteLine("Company deleted");
    }
}
class Department
{   //instance variables
    public string name;
    public List<Employee> employees; //list to store objects for employees
    public Department(string name) //parameterized constructor
    {
        this.name = name;
        employees = new List<Employee>();
    }
    public void AddEmployee(Employee employee) //method to add employee
    {
        employee.department = this;
        employees.Add(employee);
    }
    ~Department() //destructor
    {
        Console.WriteLine("Department deleted");
    }
}
class Employee
{   //instance variables
    public string name;
    public Department department;
    public Employee(string name) //parameterized constructor
    {
        this.name = name;
    }
    ~Employee() //destructor
    {
        Console.WriteLine("Employee deleted");
    }
}
class Program
{
    static void Main()
    {
        Company company = new Company("ABC Company"); //object creation
        Department department = new Department("IT"); //object creation
        Employee employee = new Employee("Harsh"); //object creation
        company.AddDepartment(department); //calling method to add department
        department.AddEmployee(employee); //calling method to add employee
        company = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}