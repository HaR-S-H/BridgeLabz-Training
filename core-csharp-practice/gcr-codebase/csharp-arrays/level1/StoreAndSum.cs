using System;

class StoreAndSum
{
    static void Main()
    {   // declare an array to hold up to 10 numbers
        double[] numbers = new double[10];

        // initialize total sum and index variables
        double total = 0.0;

        int index = 0;

        while (true)
        {
            Console.WriteLine("enter a number");
            
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
