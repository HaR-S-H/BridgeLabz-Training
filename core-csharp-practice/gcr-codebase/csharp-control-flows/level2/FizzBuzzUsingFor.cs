using System;
class FizzBuzzUsingFor
{
    static void Main()
    {   // take a positive number as input from user
        Console.Write("enter a positive number");
        int num = int.Parse(Console.ReadLine());
        // FizzBuzz logic using for loop
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}