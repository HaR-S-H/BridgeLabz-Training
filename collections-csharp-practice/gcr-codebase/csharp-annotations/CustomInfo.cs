using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("High", "Harsh")]
    public void CompleteTask() { }
}

class Program
{
    static void Main()
    {
        var method = typeof(TaskManager).GetMethod("CompleteTask");
        var attr = (TaskInfoAttribute)Attribute.GetCustomAttribute(method, typeof(TaskInfoAttribute));

        Console.WriteLine($"Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
    }
}
