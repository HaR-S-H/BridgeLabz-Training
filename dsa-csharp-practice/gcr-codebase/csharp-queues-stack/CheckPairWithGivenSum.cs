using System.Collections.Generic;

class PairWithSum
{
    public static bool HasPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            if (set.Contains(target - num))
                return true;

            set.Add(num);
        }
        return false;
    }
}
