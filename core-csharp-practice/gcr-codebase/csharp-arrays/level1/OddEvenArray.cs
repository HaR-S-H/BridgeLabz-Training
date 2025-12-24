using System;

class OddEvenArray
{
    static void Main()
    {   // take a number as input from user
        Console.WriteLine("enter a number");

        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Invalid input. Not a natural number.");
            return;
        }
        // declare arrays to hold even and odd numbers
        int[] even = new int[number / 2 + 1];
        
        int[] odd = new int[number / 2 + 1];

        int evenIndex = 0;

        int oddIndex = 0;

        // separate even and odd numbers
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                even[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                odd[oddIndex] = i;
            
                oddIndex++;
            }
        }
    // display even and odd numbers
        Console.WriteLine("even numbers");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.WriteLine(even[i]);
        }

        Console.WriteLine("Odd Numbers:");

        
        for (int i = 0; i < oddIndex; i++)
        {
            Console.WriteLine(odd[i]);
        }
    }
}
