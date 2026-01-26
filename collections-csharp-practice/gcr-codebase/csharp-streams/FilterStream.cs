using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using (BufferedStream bsIn = new BufferedStream(File.OpenRead("input.txt")))
        using (BufferedStream bsOut = new BufferedStream(File.Create("output.txt")))
        using (StreamReader reader = new StreamReader(bsIn, Encoding.UTF8))
        using (StreamWriter writer = new StreamWriter(bsOut, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
                writer.WriteLine(line.ToLower());
        }
    }
}
