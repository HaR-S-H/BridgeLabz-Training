class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int taskId, string taskName, int priority, string dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskCircularLinkedList
{
    private TaskNode head;
    private TaskNode current; // for scheduler navigation

    // Add at Beginning
    public void AddAtBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            newNode.Next = head;
            temp.Next = newNode;
            head = newNode;
        }

        Console.WriteLine("Task added at beginning.");
    }

    // Add at End
    public void AddAtEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        Console.WriteLine("Task added at end.");
    }

    // Add at Specific Position (1-based index)
    public void AddAtPosition(int position, int id, string name, int priority, string dueDate)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }

        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        TaskNode temp = head;

        for (int i = 1; i < position - 1 && temp.Next != head; i++)
        {
            temp = temp.Next;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;

        Console.WriteLine("Task added at position " + position);
    }

    // Remove by Task ID
    public void RemoveByTaskId(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        TaskNode currentNode = head;
        TaskNode prev = null;

        do
        {
            if (currentNode.TaskId == id)
            {
                // If only one node
                if (currentNode == head && currentNode.Next == head)
                {
                    head = null;
                    current = null;
                }
                // If head node
                else if (currentNode == head)
                {
                    TaskNode temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }

                    head = head.Next;
                    temp.Next = head;
                    if (current == currentNode)
                        current = head;
                }
                // If middle or last
                else
                {
                    prev.Next = currentNode.Next;
                    if (current == currentNode)
                        current = currentNode.Next;
                }

                Console.WriteLine("Task removed successfully.");
                return;
            }

            prev = currentNode;
            currentNode = currentNode.Next;

        } while (currentNode != head);

        Console.WriteLine("Task not found.");
    }

    // View Current Task and Move to Next
    public void ViewCurrentAndNext()
    {
        if (current == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("\nCurrent Task:");
        DisplayTask(current);

        current = current.Next;
        Console.WriteLine("Moved to next task.");
    }

    // Display All Tasks from Head
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to display.");
            return;
        }

        Console.WriteLine("\nAll Tasks:");
        TaskNode temp = head;
        do
        {
            DisplayTask(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Search by Priority
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks in list.");
            return;
        }

        TaskNode temp = head;
        bool found = false;

        do
        {
            if (temp.Priority == priority)
            {
                DisplayTask(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No tasks found with this priority.");
    }

    // Helper Method
    private void DisplayTask(TaskNode task)
    {
        Console.WriteLine($"ID: {task.TaskId}, Name: {task.TaskName}, Priority: {task.Priority}, Due Date: {task.DueDate}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskCircularLinkedList scheduler = new TaskCircularLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n==== Task Scheduler ====");
            Console.WriteLine("1. Add Task at Beginning");
            Console.WriteLine("2. Add Task at End");
            Console.WriteLine("3. Add Task at Position");
            Console.WriteLine("4. Remove Task by ID");
            Console.WriteLine("5. View Current Task & Move Next");
            Console.WriteLine("6. Display All Tasks");
            Console.WriteLine("7. Search by Priority");
            Console.WriteLine("8. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int id, priority, position;
            string name, dueDate;

            switch (choice)
            {
                case 1:
                    ReadTask(out id, out name, out priority, out dueDate);
                    scheduler.AddAtBeginning(id, name, priority, dueDate);
                    break;

                case 2:
                    ReadTask(out id, out name, out priority, out dueDate);
                    scheduler.AddAtEnd(id, name, priority, dueDate);
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    position = Convert.ToInt32(Console.ReadLine());
                    ReadTask(out id, out name, out priority, out dueDate);
                    scheduler.AddAtPosition(position, id, name, priority, dueDate);
                    break;

                case 4:
                    Console.Write("Enter Task ID to Remove: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    scheduler.RemoveByTaskId(id);
                    break;

                case 5:
                    scheduler.ViewCurrentAndNext();
                    break;

                case 6:
                    scheduler.DisplayAll();
                    break;

                case 7:
                    Console.Write("Enter Priority to Search: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    scheduler.SearchByPriority(priority);
                    break;

                case 8:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 8);
    }

    static void ReadTask(out int id, out string name, out int priority, out string dueDate)
    {
        Console.Write("Task ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Task Name: ");
        name = Console.ReadLine();
        Console.Write("Priority: ");
        priority = Convert.ToInt32(Console.ReadLine());
        Console.Write("Due Date: ");
        dueDate = Console.ReadLine();
    }
}
