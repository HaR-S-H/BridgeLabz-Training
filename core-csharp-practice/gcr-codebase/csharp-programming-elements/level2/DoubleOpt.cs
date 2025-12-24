using System;

class DoubleOpt
{
    static void Main()
    {   //take three double values as input from user
        Console.Write("enter a");

        double a = Convert.ToDouble(Console.ReadLine());
        //b
        Console.Write("enter b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter c");
        double c = Convert.ToDouble(Console.ReadLine());
        //perform double operations
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;
        //print the result
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
