using System;

class MathUtility
{
    // 1. Factorial of a number
    public static long Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers.");

        long result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    // 2. Check if a number is prime
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    // 3. Find GCD using Euclidean Algorithm
    public static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }

    // 4. Find nth Fibonacci number
    public static long Fibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("Fibonacci is not defined for negative numbers.");

        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        long first = 0;
        long second = 1;

        for (int i = 2; i <= n; i++)
        {
            long next = first + second;
            first = second;
            second = next;
        }

        return second;
    }
}

class Program
{
    static void Main()
    {
        // Factorial Tests
        Console.WriteLine("Factorial Tests:");
        Console.WriteLine("5! = " + MathUtility.Factorial(5));
        Console.WriteLine("0! = " + MathUtility.Factorial(0));

        // Prime Tests
        Console.WriteLine("\nPrime Number Tests:");
        Console.WriteLine("Is 7 prime? " + MathUtility.IsPrime(7));
        Console.WriteLine("Is 1 prime? " + MathUtility.IsPrime(1));
        Console.WriteLine("Is -5 prime? " + MathUtility.IsPrime(-5));

        // GCD Tests
        Console.WriteLine("\nGCD Tests:");
        Console.WriteLine("GCD of 48 and 18 = " + MathUtility.GCD(48, 18));
        Console.WriteLine("GCD of -20 and 30 = " + MathUtility.GCD(-20, 30));

        // Fibonacci Tests
        Console.WriteLine("\nFibonacci Tests:");
        Console.WriteLine("Fibonacci(0) = " + MathUtility.Fibonacci(0));
        Console.WriteLine("Fibonacci(1) = " + MathUtility.Fibonacci(1));
        Console.WriteLine("Fibonacci(10) = " + MathUtility.Fibonacci(10));

        Console.ReadLine();
    }
}
