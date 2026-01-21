using System;
using System.Collections.Generic;

class RemoveDuplicatesDemo
{
    static void Main()
    {
        List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int i in list)
        {
            if (seen.Add(i))
                result.Add(i);
        }

        Console.WriteLine("After Removing Duplicates:");
        foreach (int i in result)
            Console.Write(i + " ");
    }
}
