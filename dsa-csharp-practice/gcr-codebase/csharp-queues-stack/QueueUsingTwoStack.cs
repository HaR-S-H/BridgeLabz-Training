using System.Collections.Generic;

class QueueUsingStacks
{
    Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();

    public void Enqueue(int x)
    {
        s1.Push(x);
    }

    public int Dequeue()
    {
        if (s2.Count == 0)
        {
            while (s1.Count > 0)
                s2.Push(s1.Pop());
        }

        return s2.Pop();
    }
}
