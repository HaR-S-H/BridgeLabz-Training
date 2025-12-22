using System;

class NumberDivisibleByFive
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool divisible = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {divisible}");
    }
}
