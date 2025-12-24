using System;
class FactorsOfNumber
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter number");
        int num = int.Parse(Console.ReadLine());
        // display factors of the number
        Console.WriteLine("Factors");
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}