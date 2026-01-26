using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("largefile.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    Console.WriteLine(line);
            }
        }
    }
}
