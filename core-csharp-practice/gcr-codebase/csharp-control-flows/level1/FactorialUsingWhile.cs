using System;

class FactorialUsingWhile
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
        int counter = 1;

        while (counter <= number)
        {
            factorial *= counter;
            counter++;
        }

        Console.WriteLine($"The factorial of {number} is {factorial}");
    }
}
