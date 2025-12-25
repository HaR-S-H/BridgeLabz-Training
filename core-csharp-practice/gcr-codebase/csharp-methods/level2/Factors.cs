using System;

class Factors
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(num);

        Console.WriteLine("Factors:");
        foreach (int f in factors)
            Console.Write(f + " ");

        Console.WriteLine("\nSum of factors: " + FindSum(factors));
        Console.WriteLine("Product of factors: " + FindProduct(factors));
        Console.WriteLine("Sum of squares of factors: " + FindSumOfSquares(factors));
    }

    static int[] FindFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0)
                count++;

        int[] arr = new int[count];
        int index = 0;

        for (int i = 1; i <= n; i++)
            if (n % i == 0)
                arr[index++] = i;

        return arr;
    }

    static int FindSum(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr)
            sum += x;
        return sum;
    }

    static int FindProduct(int[] arr)
    {
        int product = 1;
        foreach (int x in arr)
            product *= x;
        return product;
    }

    static double FindSumOfSquares(int[] arr)
    {
        double sum = 0;
        foreach (int x in arr)
            sum += Math.Pow(x, 2);
        return sum;
    }
}
