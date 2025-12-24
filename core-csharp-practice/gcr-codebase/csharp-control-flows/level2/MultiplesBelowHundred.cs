using System;
class MultiplesBelowHundred
{
    static void Main()
    {   // take a number as input from user
        Console.Write("enter number");
        int n = int.Parse(Console.ReadLine());
    
        for (int i = 100; i >= 1; i--)
        {
            if (i % n == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}