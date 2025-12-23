using System;

class MultiplicationTable
{
    static void Main()
    {
        int number;
        int[] table = new int[10];

        Console.WriteLine("Enter a number:");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + table[i - 1]);
        }
    }
}
