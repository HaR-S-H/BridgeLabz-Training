using System;
using System.Linq;

class Program
{
    // Radix Sort
    public static void RadixSort(long[] arr)
    {
        long max = arr.Max();

        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountSort(arr, exp);
        }
    }

    // Counting Sort for a digit
    public static void CountSort(long[] arr, long exp)
    {
        int n = arr.Length;
        long[] output = new long[n];
        int[] count = new int[10];

        // Frequency count
        for (int i = 0; i < n; i++)
        {
            int digit = (int)((arr[i] / exp) % 10);
            count[digit]++;
        }

        // Cumulative count
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        // Build output (RIGHT TO LEFT → stability)
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((arr[i] / exp) % 10);
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        // Copy back
        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }

    static void Main()
    {
        long[] adharNumbers =
        {
            123456789012,
            987654321098,
            456789123456,
            789123456789,
            321654987321
        };

        RadixSort(adharNumbers);

        Console.WriteLine("Sorted Aadhaar Numbers:");
        foreach (long adharNumber in adharNumbers)
        {
            Console.WriteLine(adharNumber);
        }
    }
}
