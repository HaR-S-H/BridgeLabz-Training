using System;

class SumUntilZero
{
    static void Main()
    {
        double total = 0;
        double number;

        do
        {
            Console.Write("Enter number: ");
            number = double.Parse(Console.ReadLine());
            total += number;
        } while (number != 0);

        Console.WriteLine($"Total sum is {total}");
    }
}
