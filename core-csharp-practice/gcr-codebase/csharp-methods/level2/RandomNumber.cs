using System;

class RandomNumber
{
    static void Main()
    {
        int[] arr = Generate4DigitRandomArray(5);
        double[] result = FindAverageMinMax(arr);

        Console.WriteLine("Average: " + result[0]);
        Console.WriteLine("Min: " + result[1]);
        Console.WriteLine("Max: " + result[2]);
    }

    static int[] Generate4DigitRandomArray(int size)
    {
        Random r = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = r.Next(1000, 10000);

        return arr;
    }

    static double[] FindAverageMinMax(int[] arr)
    {
        int min = arr[0], max = arr[0], sum = 0;

        foreach (int x in arr)
        {
            sum += x;
            min = Math.Min(min, x);
            max = Math.Max(max, x);
        }

        return new double[] { (double)sum / arr.Length, min, max };
    }
}
