using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var top5 = File.ReadLines("employees.csv")
            .Skip(1)
            .Select(l => l.Split(','))
            .OrderByDescending(d => int.Parse(d[3]))
            .Take(5);

        foreach (var emp in top5)
            Console.WriteLine($"{emp[1]} - {emp[3]}");
    }
}
