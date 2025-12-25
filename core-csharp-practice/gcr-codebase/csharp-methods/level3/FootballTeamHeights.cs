using System;

class FootballTeamHeights
{
    static void Main()
    {
        int[] heights = new int[11];
        Random r = new Random();

        for (int i = 0; i < heights.Length; i++)
            heights[i] = r.Next(150, 251);

        Console.WriteLine("Player Heights:");
        foreach (int h in heights)
            Console.Write(h + " ");

        Console.WriteLine("\nShortest: " + FindShortest(heights));
        Console.WriteLine("Tallest: " + FindTallest(heights));
        Console.WriteLine("Mean Height: " + FindMean(heights));
    }

    static int FindShortest(int[] arr)
    {
        int min = arr[0];
        foreach (int x in arr)
            if (x < min) min = x;
        return min;
    }

    static int FindTallest(int[] arr)
    {
        int max = arr[0];
        foreach (int x in arr)
            if (x > max) max = x;
        return max;
    }

    static double FindMean(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr) sum += x;
        return (double)sum / arr.Length;
    }
}
