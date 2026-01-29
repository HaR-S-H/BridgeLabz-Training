using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string searchName = "Sara";

        var result = File.ReadLines("employees.csv")
                         .Skip(1)
                         .Select(l => l.Split(','))
                         .FirstOrDefault(d => d[1].Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (result != null)
            Console.WriteLine($"Department: {result[2]}, Salary: {result[3]}");
        else
            Console.WriteLine("Employee not found.");
    }
}
