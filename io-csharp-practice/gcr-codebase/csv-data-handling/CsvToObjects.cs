using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id;
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        var students = File.ReadLines("students.csv")
            .Skip(1)
            .Select(l =>
            {
                var d = l.Split(',');
                return new Student { Id = int.Parse(d[0]), Name = d[1], Age = int.Parse(d[2]) };
            }).ToList();

        students.ForEach(s => Console.WriteLine($"{s.Name} ({s.Age})"));
    }
}
