using System;

class FactorPerfectAbundant
{
    static void Main()
    {
        int n = 145;
        int[] f = GetFactors(n);

        Console.WriteLine("Perfect: " + IsPerfect(n, f));
        Console.WriteLine("Abundant: " + IsAbundant(n, f));
        Console.WriteLine("Deficient: " + IsDeficient(n, f));
        Console.WriteLine("Strong: " + IsStrong(n));
    }

    static int[] GetFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;

        int[] f = new int[count];
        int idx = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) f[idx++] = i;
        return f;
    }

    static bool IsPerfect(int n, int[] f)
    {
        int sum = 0;
        foreach (int x in f)
            if (x != n) sum += x;
        return sum == n;
    }

    static bool IsAbundant(int n, int[] f)
    {
        int sum = 0;
        foreach (int x in f)
            if (x != n) sum += x;
        return sum > n;
    }

    static bool IsDeficient(int n, int[] f)
    {
        int sum = 0;
        foreach (int x in f)
            if (x != n) sum += x;
        return sum < n;
    }

    static bool IsStrong(int n)
    {
        int temp = n, sum = 0;
        while (temp > 0)
        {
            int d = temp % 10;
            sum += Factorial(d);
            temp /= 10;
        }
        return sum == n;
    }

    static int Factorial(int n)
    {
        int f = 1;
        for (int i = 1; i <= n; i++) f *= i;
        return f;
    }
}
