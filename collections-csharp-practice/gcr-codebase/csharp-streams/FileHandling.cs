using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destPath = "destination.txt";

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        try
        {
            using (FileStream source = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream dest = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            {
                source.CopyTo(dest);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
