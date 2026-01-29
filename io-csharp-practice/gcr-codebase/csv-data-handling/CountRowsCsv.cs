using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        int count = File.ReadLines("students.csv").Skip(1).Count();
        Console.WriteLine($"Total Records: {count}");
    }
}
