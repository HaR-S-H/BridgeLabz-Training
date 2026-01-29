using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var file1 = File.ReadLines("students1.csv").Skip(1)
            .Select(l => l.Split(','))
            .ToDictionary(d => d[0]);

        var merged = new List<string> { "ID,Name,Age,Marks,Grade" };

        foreach (var line in File.ReadLines("students2.csv").Skip(1))
        {
            var d = line.Split(',');
            if (file1.ContainsKey(d[0]))
            {
                var s1 = file1[d[0]];
                merged.Add($"{d[0]},{s1[1]},{s1[2]},{d[1]},{d[2]}");
            }
        }

        File.WriteAllLines("merged.csv", merged);
    }
}
