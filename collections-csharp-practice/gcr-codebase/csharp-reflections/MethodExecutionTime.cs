using System;
using System.Diagnostics;
using System.Reflection;

class Worker
{
    public void DoWork()
    {
        System.Threading.Thread.Sleep(500);
    }
}

class Program
{
    static void Main()
    {
        var obj = new Worker();
        var method = typeof(Worker).GetMethod("DoWork");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(obj, null);
        sw.Stop();

        Console.WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}
