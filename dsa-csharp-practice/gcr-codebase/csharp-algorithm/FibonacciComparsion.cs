using System;
using System.Diagnostics;

class FibonacciComparison
{
    static void Main()
    {
        int n = 40;
        Stopwatch sw = new Stopwatch();

        // Recursive
        sw.Start();
        Console.WriteLine($"Recursive Result: {FibonacciRecursive(n)}");
        sw.Stop();
        Console.WriteLine($"Recursive Time: {sw.ElapsedMilliseconds} ms");

        // Iterative
        sw.Restart();
        Console.WriteLine($"Iterative Result: {FibonacciIterative(n)}");
        sw.Stop();
        Console.WriteLine($"Iterative Time: {sw.ElapsedMilliseconds} ms");
    }

    static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
