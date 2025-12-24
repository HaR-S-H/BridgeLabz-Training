using System;

class TableSixToNine
{
    static void Main()
    {   // declare variables
        int number;


        int[] result = new int[4];
        // take a number as input from user
        Console.WriteLine("enter a number");
        

        number = int.Parse(Console.ReadLine());

        int index = 0;
    //  generate multiplication table from 6 to 9 and store in array
        for (int i = 6; i <= 9; i++)
        {
            result[index] = number * i;
            index++;
        }

        index = 0;

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + result[index]);
            index++;
        }
    }
}
