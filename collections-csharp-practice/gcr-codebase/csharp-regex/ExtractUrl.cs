using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        var matches = Regex.Matches(text, @"https?://[^\s]+");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
