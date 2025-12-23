using System;

class NumberCheck
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter number " + (i + 1));
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i] + " is Positive Even");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is Positive Odd");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine(numbers[i] + " is Negative");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is Zero");
            }
        }

        if (numbers[0] == numbers[4])
        {
            Console.WriteLine("First and last elements are equal");
        }
        else if (numbers[0] > numbers[4])
        {
            Console.WriteLine("First element is greater than last");
        }
        else
        {
            Console.WriteLine("First element is less than last");
        }
    }
}
