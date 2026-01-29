using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Regex emailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phoneRegex = new(@"^\d{10}$");

        foreach (var line in File.ReadLines("contacts.csv").Skip(1))
        {
            var data = line.Split(',');
            string email = data[2];
            string phone = data[3];

            if (!emailRegex.IsMatch(email) || !phoneRegex.IsMatch(phone))
                Console.WriteLine($"Invalid Row: {line}");
        }
    }
}
