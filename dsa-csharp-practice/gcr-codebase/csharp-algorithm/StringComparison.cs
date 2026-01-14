using System;
using System.Diagnostics;
using System.Text;

class StringComparison
{
    static void Main()
    {
        int n = 100_000;
        Stopwatch sw = new Stopwatch();

        // Using string
        string s = "";
        sw.Start();
        for (int i = 0; i < n; i++)
            s += "a";
        sw.Stop();
        Console.WriteLine($"string Time: {sw.ElapsedMilliseconds} ms");

        // Using StringBuilder
        StringBuilder sb = new StringBuilder();
        sw.Restart();
        for (int i = 0; i < n; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine($"StringBuilder Time: {sw.ElapsedMilliseconds} ms");
    }
}
