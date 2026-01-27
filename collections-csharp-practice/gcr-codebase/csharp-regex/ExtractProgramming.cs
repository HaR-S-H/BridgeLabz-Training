using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        var matches = Regex.Matches(text, @"\b(Java|Python|JavaScript|Go)\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
