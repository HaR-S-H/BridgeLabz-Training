using System;
using System.Collections.Generic;
class VehicleQueue
{
    private Queue<string> queue;
    private int capacity;

    public VehicleQueue(int capacity)
    {
        this.capacity = capacity;
        queue = new Queue<string>();
    }

    public void Enqueue(string number)
    {
        if (queue.Count == capacity)
        {
            Console.WriteLine("Queue Overflow!");
            return;
        }

        queue.Enqueue(number);
        Console.WriteLine("Vehicle added to queue.");
    }

    public string Dequeue()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Queue Underflow!");
            return null;
        }

        return queue.Dequeue();
    }

    public override string ToString()
    {
        return "Queue: " + string.Join(", ", queue);
    }
}
