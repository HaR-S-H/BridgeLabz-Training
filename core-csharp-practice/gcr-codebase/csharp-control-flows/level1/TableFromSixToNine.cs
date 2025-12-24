using System;

class TableFromSixToNine
{
    static void Main()
    {// take a number as input from user
        Console.Write("enter a number");
        int number = int.Parse(Console.ReadLine());
    // display multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
