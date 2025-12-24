using System;

class DigitFrequency
{
    static void Main()
    {   // take number as input from user
        Console.WriteLine("enter a number");

        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int count = 0;

        while (temp != 0)
        {
            count++;
            temp = temp / 10;
        }
        // store digits in an array
        int[] digits = new int[count];


        temp = number;

        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp = temp / 10;
        }
// calculate frequency of each digit
        int[] frequency = new int[10];



        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++;
        }


        // display frequency of each digit
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " occurs " + frequency[i] + " times");
            }
        }
    }
}
