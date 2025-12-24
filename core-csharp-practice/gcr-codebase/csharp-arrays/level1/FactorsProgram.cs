using System;

class FactorsProgram
{
    static void Main()
    {   // take a number as input from user
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());
        // declare an array to store factors
        int maxSize = 10;
        int[] factors = new int[maxSize];
        int index = 0;
        // find factors of the number and store them in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxSize)
                {
                    maxSize = maxSize * 2;
                    int[] temp = new int[maxSize];

                    for (int j = 0; j < factors.Length; j++)
                    {
                        temp[j] = factors[j];
                    }

                    factors = temp;
                }

                factors[index] = i;
                index++;
            }
        }
        // display the factors
        Console.WriteLine("factors are");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }
}
