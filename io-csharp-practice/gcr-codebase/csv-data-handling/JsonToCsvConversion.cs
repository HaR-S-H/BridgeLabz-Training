using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Student { public int Id { get; set; } public string Name { get; set; } }

class Program
{
    static void Main()
    {
        var json = File.ReadAllText("students.json");
        var students = JsonSerializer.Deserialize<List<Student>>(json);

        using var writer = new StreamWriter("students.csv");
        writer.WriteLine("Id,Name");
        foreach (var s in students)
            writer.WriteLine($"{s.Id},{s.Name}");

        // CSV back to JSON
        var list = new List<Student>();
        foreach (var line in File.ReadLines("students.csv").Skip(1))
        {
            var d = line.Split(',');
            list.Add(new Student { Id = int.Parse(d[0]), Name = d[1] });
        }

        File.WriteAllText("students_out.json", JsonSerializer.Serialize(list));
    }
}
