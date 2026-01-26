using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string text = reader.ReadToEnd();
            foreach (Match match in Regex.Matches(text, @"\b\w+\b"))
            {
                string word = match.Value.ToLower();
                dict[word] = dict.ContainsKey(word) ? dict[word] + 1 : 1;
            }
        }

        var top5 = dict.OrderByDescending(x => x.Value).Take(5);

        foreach (var item in top5)
            Console.WriteLine($"{item.Key} - {item.Value}");
    }
}
