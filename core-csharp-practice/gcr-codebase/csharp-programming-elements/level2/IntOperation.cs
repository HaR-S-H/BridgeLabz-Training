using System;

class IntOperation
{
    static void Main()
    {   //take three integer values as input from user
        Console.Write("enter a");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter b");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter c");
        int c = Convert.ToInt32(Console.ReadLine());
        //perform int operations
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;
        //print the result
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
