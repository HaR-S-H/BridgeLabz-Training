using System;

class SumOfNaturalNumbersUsingFor
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter a number");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("The entered number is not a natural number.");
            return;
        }

        int sumUsingFor = 0;
        // calculate sum using for loop
        for (int i = 1; i <= number; i++)
        {
            sumUsingFor += i;
        }

        int sumUsingFormula = number * (number + 1) / 2;
        // display the results
        Console.WriteLine(sumUsingFor);
        Console.WriteLine(sumUsingFormula);
    }
}
