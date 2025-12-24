using System;

class ArmstrongNumber
{
    static void Main()
    {   /// declare variables
        int number;


        int originalNumber;

        int remainder;
        int sum = 0;

        Console.WriteLine("enter a number");

        
        number = int.Parse(Console.ReadLine());

        originalNumber = number;

        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            sum = sum + (remainder * remainder * remainder);
            originalNumber = originalNumber / 10;
        }

        if (sum == number)
        {
            Console.WriteLine("It is an Armstrong Number");
        }
        else
        {
            Console.WriteLine("It is NOT an Armstrong Number");
        }
    }
}
