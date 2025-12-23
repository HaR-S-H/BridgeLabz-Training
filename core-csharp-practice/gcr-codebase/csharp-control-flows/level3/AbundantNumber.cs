using System;

class AbundantNumber
{
    static void Main()
    {
        int number;
        int sum = 0;

        Console.WriteLine("Enter a number:");
        number = int.Parse(Console.ReadLine());

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
