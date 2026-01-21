using System;
using System.Collections.Generic;

class BinaryNumbersDemo
{
    static void Main()
    {
        int n = 5;
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string curr = q.Dequeue();
            Console.Write(curr + " ");

            q.Enqueue(curr + "0");
            q.Enqueue(curr + "1");
        }
    }
}
