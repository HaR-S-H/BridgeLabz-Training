using System;

class NumberIsSmallest
{
    static void Main()
    {
        Console.Write("Enter number1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter number3: ");
        int c = int.Parse(Console.ReadLine());

        bool isSmallest = a < b && a < c;
        Console.WriteLine($"Is the first number the smallest? {isSmallest}");
    }
}
