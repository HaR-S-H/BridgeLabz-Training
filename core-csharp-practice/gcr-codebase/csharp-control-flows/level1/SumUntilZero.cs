using System;

class SumUntilZero
{
    static void Main()
    {   // initialize total sum variable
        double total = 0;
        double number;

        do
        {
            Console.Write("enter number");
            number = double.Parse(Console.ReadLine());
            total += number;
        } while (number != 0);

        Console.WriteLine($"total sum is {total}");
    }
}
