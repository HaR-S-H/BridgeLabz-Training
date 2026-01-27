using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string card = "4123456789012345";
        string pattern = @"^(4\d{15}|5\d{15})$";

        Console.WriteLine(Regex.IsMatch(card, pattern) ? "Valid Card" : "Invalid Card");
    }
}
