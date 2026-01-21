using System;
using System.Collections.Generic;

class ReverseLinkedList
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>(
            new int[] { 1, 2, 3, 4, 5 });

        LinkedList<int> reversed = new LinkedList<int>();

        foreach (var item in list)
            reversed.AddFirst(item);

        Console.WriteLine("Reversed LinkedList:");
        foreach (var item in reversed)
            Console.Write(item + " ");
    }
}
