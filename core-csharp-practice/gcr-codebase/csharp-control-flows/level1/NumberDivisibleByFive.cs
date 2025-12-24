using System;

class NumberDivisibleByFive
{
    static void Main()
    {    // take a number as input from user
        Console.Write("enter number");
        int number = int.Parse(Console.ReadLine());
        // check if the number is divisible by 5
        bool divisible = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {divisible}");
    }
}
