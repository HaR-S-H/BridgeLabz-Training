using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        var matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
