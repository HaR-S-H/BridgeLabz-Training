using System;

class CountDowmUsingWhile
{
    static void Main()
    {
        Console.Write("Enter countdown number: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
