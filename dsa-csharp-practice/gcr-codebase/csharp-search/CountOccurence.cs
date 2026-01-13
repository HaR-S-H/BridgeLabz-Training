using System;
using System.IO;

class Program
{
    static void Main()
    {
        string word = "hello";
        int count = 0;

        using (StreamReader sr = new StreamReader("sample.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(' ', ',', '.', '!');
                foreach (string p in parts)
                {
                    if (p.Equals(word, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }
        }

        Console.WriteLine("Occurrences: " + count);
    }
}
