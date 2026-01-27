using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";
        var matches = Regex.Matches(text, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
