using System;
using System.IO;

class Program
{
    static void Main()
    {
        string file = "students.dat";

        using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
        {
            bw.Write(1);
            bw.Write("Rahul");
            bw.Write(8.5);
        }

        using (BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open)))
        {
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
