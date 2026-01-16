using System;
using System;
using System.Collections.Generic;

public class BrowserUtility : IBrowserManager
{
    private HistoryNode head;
    private HistoryNode current;
    private Stack<HistoryNode> closedTabs;

    public BrowserUtility()
    {
        head = null;
        current = null;
        closedTabs = new Stack<HistoryNode>();
    }

    // VISIT NEW URL
    public void Visit(string url)
    {
        HistoryNode newNode = new HistoryNode(url);

        if (head == null)
        {
            head = newNode;
            current = newNode;
        }
        else
        {
            // Remove forward history
            current.Next = null;

            newNode.Prev = current;
            current.Next = newNode;
            current = newNode;
        }

        Console.WriteLine("Visited: " + current);
    }

    // GO BACK
    public void Back()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Back to: " + current);
        }
        else
        {
            Console.WriteLine("No previous page.");
        }
    }

    // GO FORWARD
    public void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Forward to: " + current);
        }
        else
        {
            Console.WriteLine("No forward page.");
        }
    }

    // DISPLAY HISTORY
    public void DisplayHistory()
    {
        if (head == null)
        {
            Console.WriteLine("No browsing history.");
            return;
        }

        HistoryNode temp = head;
        Console.WriteLine("\nBrowsing History:");

        while (temp != null)
        {
            if (temp == current)
                Console.Write("[" + temp + "] ");
            else
                Console.Write(temp + " ");

            temp = temp.Next;
        }
        Console.WriteLine();
    }

    // CLOSE TAB (PUSH TO STACK)
    public void CloseTab()
    {
        if (head != null)
        {
            closedTabs.Push(head);
            head = null;
            current = null;
            Console.WriteLine("Tab closed.");
        }
        else
        {
            Console.WriteLine("No active tab to close.");
        }
    }

    // RESTORE TAB (POP FROM STACK)
    public void RestoreTab()
    {
        if (closedTabs.Count > 0)
        {
            head = closedTabs.Pop();
            current = head;

            // Move current to last visited page
            while (current.Next != null)
                current = current.Next;

            Console.WriteLine("Tab restored. Current page: " + current);
        }
        else
        {
            Console.WriteLine("No closed tabs to restore.");
        }
    }
}
