using System;
using System.Collections.Generic;

class UnionIntersectionDemo
{
    static void Main()
    {
        HashSet<int> s1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> s2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> union = new HashSet<int>(s1);
        union.UnionWith(s2);

        HashSet<int> intersection = new HashSet<int>(s1);
        intersection.IntersectWith(s2);

        Console.WriteLine("Union:");
        foreach (int i in union) Console.Write(i + " ");

        Console.WriteLine("\nIntersection:");
        foreach (int i in intersection) Console.Write(i + " ");
    }
}
