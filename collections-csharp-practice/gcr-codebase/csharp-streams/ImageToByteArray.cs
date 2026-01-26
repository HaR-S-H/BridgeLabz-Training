using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputImage = "input.jpg";
        string outputImage = "output.jpg";

        try
        {
            byte[] imageBytes = File.ReadAllBytes(inputImage);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes(outputImage, ms.ToArray());
            }

            Console.WriteLine("Image copied via byte array.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
