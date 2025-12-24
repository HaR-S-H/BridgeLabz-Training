using System;

class SwapTwoNumbers
{
    static void Main()
    {   // take two numbers as input from user
        Console.Write("enter first number");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        // swap the numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;
        // print the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}
