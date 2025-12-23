using System;
class FactorsOfNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Factors:");
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}