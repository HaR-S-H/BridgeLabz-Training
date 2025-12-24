using System;

class ReverseNumber
{
    static void Main()
    {   // take number as input
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());

        int temp = number;

        int count = 0;
    //  count number of digits


        while (temp != 0)
        {
            count++;
            temp = temp / 10;
        }

        int[] digits = new int[count];
        temp = number;
        // store digits in an array in reverse order
        
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp = temp / 10;
        }
    // display reversed number
    

        Console.WriteLine("Reversed Number:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i]);
        }
    }
}
