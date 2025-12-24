using System;

class CountDownUsingFor
{
    static void Main()
    {   // take countdown number as input from user
        Console.Write("enter countdown number");
        // read the number
        int n = int.Parse(Console.ReadLine());
        // countdown from n to 1 using for loop
        for (int i = n; i >= 1; i--)
            Console.WriteLine(i);
    }
}
