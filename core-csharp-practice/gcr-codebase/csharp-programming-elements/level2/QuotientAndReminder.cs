using System;

class QuotientAndReminder
{
    static void Main()
    {   //  take two integers as input from user
        Console.Write("enter first number");


        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter second number");

        int number2 = Convert.ToInt32(Console.ReadLine());
    // calculate quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;
    // print the result
        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
    }
}
