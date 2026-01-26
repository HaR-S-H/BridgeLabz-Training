using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        string file = "employees.json";

        var employees = new List<Employee>
        {
            new Employee{ Id=1, Name="Alice", Department="HR", Salary=50000 },
            new Employee{ Id=2, Name="Bob", Department="IT", Salary=70000 }
        };

        // Serialize
        File.WriteAllText(file, JsonSerializer.Serialize(employees));

        // Deserialize
        var loaded = JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText(file));

        foreach (var emp in loaded)
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Department} {emp.Salary}");
    }
}
