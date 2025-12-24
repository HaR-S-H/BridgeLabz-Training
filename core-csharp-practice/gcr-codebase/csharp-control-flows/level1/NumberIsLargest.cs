using System;

class NumberIsLargest
{
    static void Main()
    {   // take three numbers as input from user
        Console.Write("enter number1");
        int a = int.Parse(Console.ReadLine());
        // read second number
        Console.Write("enter number2");
        int b = int.Parse(Console.ReadLine());
        Console.Write("enter number3");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"Is the first number the largest? {a > b && a > c}");
        Console.WriteLine($"Is the second number the largest? {b > a && b > c}");
        Console.WriteLine($"Is the third number the largest? {c > a && c > b}");
    }
}
