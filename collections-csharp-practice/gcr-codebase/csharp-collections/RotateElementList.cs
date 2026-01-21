using System;
using System.Collections.Generic;

class RotateListDemo
{
    static void Main()
    {
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };
        int k = 2;

        List<int> rotated = new List<int>();
        rotated.AddRange(list.GetRange(k, list.Count - k));
        rotated.AddRange(list.GetRange(0, k));

        Console.WriteLine("Rotated List:");
        foreach (int i in rotated)
            Console.Write(i + " ");
    }
}
