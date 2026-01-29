using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var seen = new HashSet<string>();

        foreach (var line in File.ReadLines("students.csv").Skip(1))
        {
            var id = line.Split(',')[0];

            if (!seen.Add(id))
                Console.WriteLine($"Duplicate Record: {line}");
        }
    }
}
