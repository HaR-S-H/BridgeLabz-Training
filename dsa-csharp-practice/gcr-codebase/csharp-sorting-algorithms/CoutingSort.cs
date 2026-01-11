using System;

class CountingSortExample
{
    static void CountingSort(int[] arr)
    {
        int min = 10, max = 18;
        int range = max - min + 1;

        int[] count = new int[range];
        int[] output = new int[arr.Length];

        foreach (int age in arr)
            count[age - min]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }

        for (int i = 0; i < arr.Length; i++)
            arr[i] = output[i];
    }

    static void Main()
    {
        int[] ages = { 12, 15, 10, 14, 18, 11, 13 };

        CountingSort(ages);

        Console.WriteLine("Sorted Student Ages:");
        foreach (int a in ages)
            Console.Write(a + " ");
    }
}
