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
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 15;
        Console.WriteLine(HasPair(arr, target));
        
    }
}
