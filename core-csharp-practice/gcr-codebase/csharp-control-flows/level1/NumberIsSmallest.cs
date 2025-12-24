using System;

class NumberIsSmallest
{
    static void Main()
    {   // take three numbers as input from user
        Console.Write("enter number1");
        int a = int.Parse(Console.ReadLine());
        Console.Write("enter number2");
        int b = int.Parse(Console.ReadLine());
        Console.Write("enter number3");
        int c = int.Parse(Console.ReadLine());
        // check if the first number is the smallest
        bool isSmallest = a < b && a < c;
        Console.WriteLine($"Is the first number the smallest? {isSmallest}");
    }
}
