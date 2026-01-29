using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = File.ReadLines("students.csv").Skip(1);

        foreach (var line in students)
        {
            var data = line.Split(',');
            if (int.Parse(data[3]) > 80)
                Console.WriteLine(line);
        }
    }
}
    