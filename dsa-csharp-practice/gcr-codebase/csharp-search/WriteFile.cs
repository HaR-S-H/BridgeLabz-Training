using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        File.WriteAllText("output.txt", input);
        Console.WriteLine("Data written to file.");
    }
}
