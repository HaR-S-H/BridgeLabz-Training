using System;

class Program
{
    static void Main()
    {
        double totalSum = 0.0;

        while (true)
        {
            Console.Write("enter a number");
            double inputNumber = double.Parse(Console.ReadLine());

            if (inputNumber <= 0)
            {
                break;
            }

            totalSum += inputNumber;
        }

        Console.WriteLine($"the total sum is {totalSum}");
    }
}
