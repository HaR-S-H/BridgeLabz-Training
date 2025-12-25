using System;

class NumberCheck
{
    static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            arr[i] = int.Parse(Console.ReadLine());

            if (IsPositive(arr[i]))
                Console.WriteLine(IsEven(arr[i]) ? "Positive Even" : "Positive Odd");
            else
                Console.WriteLine("Negative");
        }

        int result = Compare(arr[0], arr[4]);
        Console.WriteLine(result == 0 ? "Equal" : result == 1 ? "First Greater" : "First Smaller");
    }

    static bool IsPositive(int n) => n >= 0;
    static bool IsEven(int n) => n % 2 == 0;

    static int Compare(int a, int b)
    {
        if (a > b) return 1;
        if (a == b) return 0;
        return -1;
    }
}
