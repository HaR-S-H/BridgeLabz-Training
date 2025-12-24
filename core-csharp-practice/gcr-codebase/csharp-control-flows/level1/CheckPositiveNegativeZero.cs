using System;

class CheckPositiveNegativeZero
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter number");


        int number = int.Parse(Console.ReadLine());
        // check if the number is positive, negative or zero
        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}
