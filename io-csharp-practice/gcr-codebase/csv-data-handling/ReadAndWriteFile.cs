using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var lines = File.ReadAllLines("students.csv").Skip(1);

        foreach (var line in lines)
        {
            var data = line.Split(',');
            Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
        }
    }
}
