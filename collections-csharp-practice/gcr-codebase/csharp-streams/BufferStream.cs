using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string source = "largefile.dat";
        string destBuffered = "copy_buffered.dat";
        string destUnbuffered = "copy_unbuffered.dat";

        byte[] buffer = new byte[4096];

        // Buffered Copy
        Stopwatch sw1 = Stopwatch.StartNew();
        using (BufferedStream bsIn = new BufferedStream(File.OpenRead(source)))
        using (BufferedStream bsOut = new BufferedStream(File.Create(destBuffered)))
        {
            int bytesRead;
            while ((bytesRead = bsIn.Read(buffer, 0, buffer.Length)) > 0)
                bsOut.Write(buffer, 0, bytesRead);
        }
        sw1.Stop();

        // Unbuffered Copy
        Stopwatch sw2 = Stopwatch.StartNew();
        using (FileStream fsIn = File.OpenRead(source))
        using (FileStream fsOut = File.Create(destUnbuffered))
        {
            int bytesRead;
            while ((bytesRead = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                fsOut.Write(buffer, 0, bytesRead);
        }
        sw2.Stop();

        Console.WriteLine($"Buffered Time: {sw1.ElapsedMilliseconds} ms");
        Console.WriteLine($"Unbuffered Time: {sw2.ElapsedMilliseconds} ms");
    }
}
