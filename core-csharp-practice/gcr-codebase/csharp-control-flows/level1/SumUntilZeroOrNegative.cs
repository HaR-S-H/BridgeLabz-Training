using System;

class Program
{
    static void Main()
    {
        double totalSum = 0.0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double inputNumber = double.Parse(Console.ReadLine());

            if (inputNumber <= 0)
            {
                break;
            }

            totalSum += inputNumber;
        }

        Console.WriteLine($"The total sum is {totalSum}");
    }
}
