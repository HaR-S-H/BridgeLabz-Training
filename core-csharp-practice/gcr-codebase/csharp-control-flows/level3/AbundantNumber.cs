using System;

class AbundantNumber
{
    static void Main()
    {   // declare variables
        int number;
        int sum = 0;
        // take input from user
        Console.WriteLine("enter a number");
        
        number = int.Parse(Console.ReadLine());
        // calculate sum of proper divisors
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum = sum + i;
            }
        }

        if (sum > number)
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Not an Abundant Number");
        }
    }
}
