using System;

class CountNumberOfDigits
{
    static void Main()
    {
        int number;
        int count = 0;

        Console.WriteLine("Enter a number:");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            number /=10;
            count++;
        }

        Console.WriteLine("Number of digits = " + count);
    }
}
