using System;

class MaximumInThreeNumbers
{
    static int FindMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
            max = b;
        if (c > max)
            max = c;

        return max;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Maximum value is: " + FindMax(a, b, c));
    }
}
