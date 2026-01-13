using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("sample.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
