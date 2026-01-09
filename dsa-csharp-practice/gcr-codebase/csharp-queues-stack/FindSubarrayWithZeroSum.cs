using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static void FindSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum == 0)
                Console.WriteLine("Subarray: 0 to " + i);

            if (map.ContainsKey(sum))
            {
                foreach (int start in map[sum])
                    Console.WriteLine($"Subarray: {start + 1} to {i}");
            }

            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, -2, 5 };
        FindSubarrays(arr);
        
    }
}
