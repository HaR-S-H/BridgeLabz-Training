using System;
class PrimeNumber
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter a number");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(n + " is Prime");
        }
        else
        {
            Console.WriteLine(n + " is not Prime");
        }
    }
}