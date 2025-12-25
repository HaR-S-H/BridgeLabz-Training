using System;

class SumNaturalNumbers
{
    static int FindSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum = " + FindSum(n));
    }
}
