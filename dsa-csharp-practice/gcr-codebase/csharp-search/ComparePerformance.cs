using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int n = 10000;

        // Using String
        Stopwatch sw1 = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += "A";
        }
        sw1.Stop();

        // Using StringBuilder
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("A");
        }
        sw2.Stop();

        Console.WriteLine("String Time: " + sw1.ElapsedMilliseconds + " ms");
        Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");
    }
}
