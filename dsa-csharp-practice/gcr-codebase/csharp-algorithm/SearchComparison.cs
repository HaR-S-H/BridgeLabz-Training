using System;
using System.Diagnostics;
using System.Linq;

class SearchComparison
{
    static void Main()
    {
        int n = 1_000_000;
        int target = n - 1;
        int[] data = Enumerable.Range(0, n).ToArray();

        Stopwatch sw = new Stopwatch();

        // Linear Search
        sw.Start();
        LinearSearch(data, target);
        sw.Stop();
        Console.WriteLine($"Linear Search Time: {sw.ElapsedMilliseconds} ms");

        // Binary Search
        sw.Restart();
        BinarySearch(data, target);
        sw.Stop();
        Console.WriteLine($"Binary Search Time: {sw.ElapsedMilliseconds} ms");
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target) return i;
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target) return mid;
            else if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}
