using System;

class CountDowmUsingWhile
{
    static void Main()
    {   // take countdown number as input from user
        Console.Write("enter  number");
        int counter = int.Parse(Console.ReadLine());
        // countdown from n to 1 using while loop
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
