using System;
class GreatestFactor
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int greatestFactor = 1;

        for (int i = num - 1; i >= 1; i--)
        {
            if (num % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine("Greatest factor besides itself: " + greatestFactor);
    }
}
