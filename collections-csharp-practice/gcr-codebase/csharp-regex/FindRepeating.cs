using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        var matches = Regex.Matches(text, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);

        foreach (Match m in matches)
            Console.WriteLine(m.Groups[1].Value);
    }
}
