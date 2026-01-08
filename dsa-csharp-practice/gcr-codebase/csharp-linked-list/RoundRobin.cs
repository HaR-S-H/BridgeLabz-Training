class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public int WaitingTime;
    public int TurnaroundTime;
    public ProcessNode Next;

    public ProcessNode(int id, int burst, int priority)
    {
        ProcessId = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        WaitingTime = 0;
        TurnaroundTime = 0;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head;
    private ProcessNode tail;
    private int processCount;

    // Add Process at End
    public void AddProcess(int id, int burst, int priority)
    {
        ProcessNode newNode = new ProcessNode(id, burst, priority);

        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
        }
        else
        {
            tail.Next = newNode;
            newNode.Next = head;
            tail = newNode;
        }

        processCount++;
        Console.WriteLine("Process added successfully.");
    }

    // Remove Process by ID
    private void RemoveProcess(int id)
    {
        if (head == null) return;

        ProcessNode current = head;
        ProcessNode prev = tail;

        do
        {
            if (current.ProcessId == id)
            {
                // Only one node
                if (current == head && current == tail)
                {
                    head = tail = null;
                }
                // Removing head
                else if (current == head)
                {
                    head = head.Next;
                    tail.Next = head;
                }
                // Removing tail
                else if (current == tail)
                {
                    tail = prev;
                    tail.Next = head;
                }
                // Middle node
                else
                {
                    prev.Next = current.Next;
                }

                processCount--;
                return;
            }

            prev = current;
            current = current.Next;

        } while (current != head);
    }

    // Display Circular Queue
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        Console.WriteLine("\nCurrent Process Queue:");
        ProcessNode temp = head;
        do
        {
            Console.WriteLine($"PID: {temp.ProcessId}, Remaining: {temp.RemainingTime}, Priority: {temp.Priority}");
            temp = temp.Next;
        } while (temp != head);
    }

    // Simulate Round Robin Scheduling
    public void Simulate(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes to schedule.");
            return;
        }

        int currentTime = 0;
        int completed = 0;
        int totalWaiting = 0;
        int totalTurnaround = 0;

        ProcessNode current = head;

        Console.WriteLine("\n--- Starting Round Robin Scheduling ---");

        while (processCount > 0)
        {
            if (current.RemainingTime > 0)
            {
                int executionTime = Math.Min(current.RemainingTime, timeQuantum);
                Console.WriteLine($"\nExecuting Process {current.ProcessId} for {executionTime} units.");

                current.RemainingTime -= executionTime;
                currentTime += executionTime;

                // If process completed
                if (current.RemainingTime == 0)
                {
                    current.TurnaroundTime = currentTime;
                    current.WaitingTime = current.TurnaroundTime - current.BurstTime;

                    totalWaiting += current.WaitingTime;
                    totalTurnaround += current.TurnaroundTime;

                    Console.WriteLine($"Process {current.ProcessId} completed.");
                    int completedId = current.ProcessId;
                    current = current.Next;
                    RemoveProcess(completedId);
                    completed++;
                    DisplayProcesses();
                    continue;
                }
            }

            current = current.Next;
        }

        // Display Averages
        Console.WriteLine("\n--- Scheduling Completed ---");
        Console.WriteLine("Total Processes: " + completed);
        Console.WriteLine("Average Waiting Time: " + (double)totalWaiting / completed);
        Console.WriteLine("Average Turnaround Time: " + (double)totalTurnaround / completed);
    }
}

class Program
{
    static void Main(string[] args)
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();
        int choice;

        do
        {
            Console.WriteLine("\n==== Round Robin Scheduling ====");
            Console.WriteLine("1. Add Process");
            Console.WriteLine("2. Display Processes");
            Console.WriteLine("3. Simulate Scheduling");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int id, burst, priority, quantum;

            switch (choice)
            {
                case 1:
                    Console.Write("Process ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Burst Time: ");
                    burst = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Priority: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    scheduler.AddProcess(id, burst, priority);
                    break;

                case 2:
                    scheduler.DisplayProcesses();
                    break;

                case 3:
                    Console.Write("Enter Time Quantum: ");
                    quantum = Convert.ToInt32(Console.ReadLine());
                    scheduler.Simulate(quantum);
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }
}
