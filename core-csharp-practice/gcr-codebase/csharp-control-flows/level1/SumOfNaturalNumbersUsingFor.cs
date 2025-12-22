using System;

class SumOfNaturalNumbersUsingFor
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("The entered number is not a natural number.");
            return;
        }

        int sumUsingFor = 0;

        for (int i = 1; i <= number; i++)
        {
            sumUsingFor += i;
        }

        int sumUsingFormula = number * (number + 1) / 2;

        Console.WriteLine($"Sum using for loop: {sumUsingFor}");
        Console.WriteLine($"Sum using formula: {sumUsingFormula}");
    }
}
