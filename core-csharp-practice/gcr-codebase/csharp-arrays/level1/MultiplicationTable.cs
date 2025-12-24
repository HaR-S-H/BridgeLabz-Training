using System;

class MultiplicationTable
{
    static void Main()
    {   // declare variables
        int number;
        int[] table = new int[10];

        Console.WriteLine("enter a number");
        number = int.Parse(Console.ReadLine());
            // generate multiplication table and store in array
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
