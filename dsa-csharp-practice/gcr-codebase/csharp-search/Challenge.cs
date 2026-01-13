using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };
        int target = 4;

        int missing = FirstMissingPositive(arr);
        Console.WriteLine("First Missing Positive: " + missing);

        Array.Sort(arr);
        int index = BinarySearch(arr, target);
        Console.WriteLine("Target Index: " + index);
    }

    // Linear Search Approach
    static int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        bool[] present = new bool[n + 1];

        foreach (int num in nums)
        {
            if (num > 0 && num <= n)
                present[num] = true;
        }

        for (int i = 1; i <= n; i++)
        {
            if (!present[i])
                return i;
        }
        return n + 1;
    }

    // Binary Search
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }
}
