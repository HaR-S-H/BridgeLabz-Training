using System;
class PutZeroesInLast
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] result = new int[n];
        int index = 0;


        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                result[index++] = arr[i];
            }
        }

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}