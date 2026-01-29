using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var updated = new List<string> { "ID,Name,Department,Salary" };

        foreach (var line in File.ReadLines("employees.csv").Skip(1))
        {
            var data = line.Split(',');
            if (data[2] == "IT")
                data[3] = (int.Parse(data[3]) * 1.1).ToString();

            updated.Add(string.Join(",", data));
        }

        File.WriteAllLines("updated_employees.csv", updated);
        Console.WriteLine("Updated file created.");
    }
}
