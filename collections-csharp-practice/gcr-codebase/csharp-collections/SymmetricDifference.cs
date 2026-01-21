using System;
using System.Collections.Generic;

class SymmetricDifferenceDemo
{
    static void Main()
    {
        HashSet<int> s1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> s2 = new HashSet<int> { 3, 4, 5 };

        s1.SymmetricExceptWith(s2);

        foreach (int i in s1)
            Console.Write(i + " ");
    }
}
