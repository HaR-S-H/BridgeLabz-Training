using System;

class NumberCheck
{
    static int CheckNumber(int num)
    {
        if (num > 0) return 1;
        if (num < 0) return -1;
        return 0;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);
        Console.WriteLine("Result = " + result);
    }
}
