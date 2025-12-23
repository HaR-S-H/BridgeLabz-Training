using System;
class PowerCalculation
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter power: ");
        int pow = int.Parse(Console.ReadLine());

        int res = 1;
        for (int i = 1; i <= pow; i++)
        {
            res *= num;
        }
        Console.WriteLine("Result: " + res);
    }
}
