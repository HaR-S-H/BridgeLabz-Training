using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream("sample.txt", FileMode.Open))
        using (StreamReader sr = new StreamReader(fs))
        {
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
