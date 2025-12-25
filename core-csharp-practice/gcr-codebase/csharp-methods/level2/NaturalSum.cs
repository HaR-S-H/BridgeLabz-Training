using System;

class NaturalSum
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int recursiveSum = SumRecursive(n);
        int formulaSum = n * (n + 1) / 2;

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);
    }

    static int SumRecursive(int n)
    {
        if (n == 1)
            return 1;
        return n + SumRecursive(n - 1);
    }
}
