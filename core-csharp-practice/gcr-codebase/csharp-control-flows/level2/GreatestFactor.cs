using System;
class GreatestFactor
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter number");
        int num = int.Parse(Console.ReadLine());
        int greatestFactor = 1;
        // find the greatest factor besides itself
        for (int i = num - 1; i >= 1; i--)
        {
            if (num % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }
        // display the greatest factor
        Console.WriteLine("Greatest factor besides itself: " + greatestFactor);
    }
}
