using System;

class Factorial
{
    static int DoFactorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Factorial: " + DoFactorial(n));
    }
}
