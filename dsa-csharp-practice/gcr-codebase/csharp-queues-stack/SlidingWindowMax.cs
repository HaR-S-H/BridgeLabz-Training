using System;
using System.Collections.Generic;

class SlidingWindowMax
{
    public static void MaxInWindow(int[] arr, int k)
    {
        LinkedList<int> dq = new LinkedList<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (dq.Count > 0 && dq.First.Value <= i - k)
                dq.RemoveFirst();

            while (dq.Count > 0 && arr[dq.Last.Value] < arr[i])
                dq.RemoveLast();

            dq.AddLast(i);

            if (i >= k - 1)
                Console.Write(arr[dq.First.Value] + " ");
        }
    }
}
