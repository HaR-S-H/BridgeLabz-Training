using System;

class FactorialUsingWhile
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

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
