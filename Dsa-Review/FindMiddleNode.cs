using System;

//find middle node
class Node
{
  public int data;
  public  Node next;
    public  Node(int data)
    {
        this.data=data;
        this.next=null;
    }
}
class LinkedList
{
    public Node head;
    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
        
    }
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + "->");
            temp = temp.next;
        }
        Console.WriteLine("null");
        
    }
    public void FindMiddle(Node slow, Node fast)
    {
        if (fast == null || fast.next == null)
        {
            Console.WriteLine(slow.data);
            return;
        }
        FindMiddle(slow.next, fast.next.next);
    }
}


class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        Console.WriteLine("Enter number of elements : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int data = int.Parse(Console.ReadLine());
            list.AddLast(data);
        }
        list.Display();
        list.FindMiddle(list.head,list.head.next);
    }
}