using System;

class FactorialUsingFor
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter a number");
        int number = int.Parse(Console.ReadLine());
        // check if the number is negative
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }

        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"The factorial of {number} is {factorial}");
    }
}
