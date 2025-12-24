using System;

class Program
{
    static void Main()
    {      // take a number as input from user
        Console.Write("enter a number");


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
    // display the results
        Console.WriteLine(sumUsingWhile);


        Console.WriteLine(sumUsingFormula);
    }
}
