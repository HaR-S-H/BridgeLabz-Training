using System;

class SumOfNuturalNumbers
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter number");

        int n = int.Parse(Console.ReadLine());
    // calculate the sum of natural numbers up to n
        if (n >= 0)
        {
            int sum = n * (n + 1) / 2;
            Console.WriteLine($"The sum of {n} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {n} is not a natural number");
        }
    }
}
