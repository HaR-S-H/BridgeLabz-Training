using System;

class StoreAndSum
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.WriteLine("Enter a number:");
            double value = double.Parse(Console.ReadLine());

            if (value <= 0 || index == 10)
            {
                break;
            }

            numbers[index] = value;
            index++;
        }

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total = total + numbers[i];
        }

        Console.WriteLine("Total = " + total);
    }
}
