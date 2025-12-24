using System;
class FizzBuzzUsingWhile
{
    static void Main()
    {   // take a positive number as input from user
        Console.Write("enter number");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
            // FizzBuzz logic using while loop
        while (i <= n)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
            i++;
        }
    }
}
