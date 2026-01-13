using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 3, 7, -2, 9 };
        int index = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                index = i;
                break;
            }
        }

        Console.WriteLine(index); // 3
    }
}
