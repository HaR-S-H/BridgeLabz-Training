using System;
class TextStateNode
{
    public string Text;
    public TextStateNode Prev;
    public TextStateNode Next;

    public TextStateNode(string text)
    {
        Text = text;
        Prev = null;
        Next = null;
    }
}

class TextEditorHistory
{
    private TextStateNode head;
    private TextStateNode tail;
    private TextStateNode current;
    private int count;
    private readonly int maxSize;

    public TextEditorHistory(int size = 10)
    {
        head = null;
        tail = null;
        current = null;
        count = 0;
        maxSize = size;
    }

    // Add new text state
    public void AddState(string text)
    {
        TextStateNode newNode = new TextStateNode(text);

        // If user typed after undo, remove all redo states
        if (current != null && current.Next != null)
        {
            TextStateNode temp = current.Next;
            while (temp != null)
            {
                TextStateNode next = temp.Next;
                temp.Prev = null;
                temp.Next = null;
                temp = next;
                count--;
            }
            current.Next = null;
            tail = current;
        }

        // Insert at end
        if (head == null)
        {
            head = tail = current = newNode;
            count = 1;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
            current = newNode;
            count++;
        }

        // Enforce size limit
        if (count > maxSize)
        {
            head = head.Next;
            head.Prev = null;
            count--;
        }

        Console.WriteLine("State added.");
    }

    // Undo operation
    public void Undo()
    {
        if (current == null || current.Prev == null)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }

        current = current.Prev;
        Console.WriteLine("Undo performed.");
    }

    // Redo operation
    public void Redo()
    {
        if (current == null || current.Next == null)
        {
            Console.WriteLine("Nothing to redo.");
            return;
        }

        current = current.Next;
        Console.WriteLine("Redo performed.");
    }

    // Display current text
    public void DisplayCurrentState()
    {
        if (current == null)
        {
            Console.WriteLine("No text available.");
            return;
        }

        Console.WriteLine("\n--- Current Text ---");
        Console.WriteLine(current.Text);
        Console.WriteLine("--------------------");
    }

    // Display all states (for debugging/demo)
    public void DisplayAllStates()
    {
        TextStateNode temp = head;
        Console.WriteLine("\nAll Text States:");
        while (temp != null)
        {
            Console.WriteLine(temp.Text);
            temp = temp.Next;
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        TextEditorHistory editor = new TextEditorHistory(10);
        int choice;
        string text;

        do
        {
            Console.WriteLine("\n==== Text Editor (Undo/Redo) ====");
            Console.WriteLine("1. Type / Add New Text");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. Display Current Text");
            Console.WriteLine("5. Display All States");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter text: ");
                    text = Console.ReadLine();
                    editor.AddState(text);
                    break;

                case 2:
                    editor.Undo();
                    editor.DisplayCurrentState();
                    break;

                case 3:
                    editor.Redo();
                    editor.DisplayCurrentState();
                    break;

                case 4:
                    editor.DisplayCurrentState();
                    break;

                case 5:
                    editor.DisplayAllStates();
                    break;

                case 6:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 6);
    }
}
