using System;

class CountNumberOfDigits
{
    static void Main()
    {// declare variables
        int number;
        int count = 0;
        // take input from user
        Console.WriteLine("enter a number");

        number = int.Parse(Console.ReadLine());
    // count number of digits
        while (number != 0)
        {
            number /=10;
            count++;
        }

        Console.WriteLine("Number of digits" + count);
    }
}
