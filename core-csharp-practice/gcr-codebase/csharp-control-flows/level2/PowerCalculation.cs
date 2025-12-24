using System;
class PowerCalculation
{
    static void Main()
    {   //  take base and exponent as input from user
        Console.Write("enter number");
        int num = int.Parse(Console.ReadLine());
        Console.Write("enter power");
        int pow = int.Parse(Console.ReadLine());

        int res = 1;
        for (int i = 1; i <= pow; i++)
        {
            res *= num;
        }
        Console.WriteLine("Result: " + res);
    }
}
