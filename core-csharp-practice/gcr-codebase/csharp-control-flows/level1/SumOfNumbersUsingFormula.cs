using System;

class Program
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

        int sumUsingWhile = 0;
        int counter = 1;

        while (counter <= number)
        {
            sumUsingWhile += counter;
            counter++;
        }

        int sumUsingFormula = number * (number + 1) / 2;

        Console.WriteLine($"Sum using while loop: {sumUsingWhile}");
        Console.WriteLine($"Sum using formula: {sumUsingFormula}");
    }
}
