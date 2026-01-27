using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string plate = "AB1234";
        string pattern = @"^[A-Z]{2}\d{4}$";

        Console.WriteLine(Regex.IsMatch(plate, pattern) ? "Valid" : "Invalid");
    }
}
