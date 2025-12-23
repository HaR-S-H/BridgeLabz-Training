using System;

class HarshadNumber
{
    static void Main()
    {
        int number;
        int temp;
        int remainder;
        int sum = 0;

        Console.WriteLine("Enter a number:");
        number = int.Parse(Console.ReadLine());

        temp = number;

        while (temp != 0)
        {
            remainder = temp % 10;
            sum = sum + remainder;
            temp = temp / 10;
        }

        if (number % sum == 0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
