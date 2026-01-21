using System;
using System.Collections.Generic;

class ReverseLinkedList
{
    static LinkedList<int> Reverse(LinkedList<int> list)
    {
        LinkedList<int> result = new LinkedList<int>();
        foreach (var item in list)
            result.AddFirst(item);

        return result;
    }
}
