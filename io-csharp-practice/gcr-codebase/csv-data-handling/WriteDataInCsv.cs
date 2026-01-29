using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var employees = new List<string>
        {
            "ID,Name,Department,Salary",
            "1,Amit,IT,60000",
            "2,Sara,HR,50000",
            "3,John,Finance,70000",
            "4,Neha,IT,80000",
            "5,Raj,Marketing,55000"
        };

        File.WriteAllLines("employees.csv", employees);
        Console.WriteLine("CSV file created.");
    }
}
