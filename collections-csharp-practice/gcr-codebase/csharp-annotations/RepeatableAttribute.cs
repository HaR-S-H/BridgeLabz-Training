using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }
    public BugReportAttribute(string desc) => Description = desc;
}

class Software
{
    [BugReport("Crash on login")]
    [BugReport("UI alignment issue")]
    public void Login() { }
}

class Program
{
    static void Main()
    {
        var method = typeof(Software).GetMethod("Login");
        var bugs = method.GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute bug in bugs)
            Console.WriteLine("Bug: " + bug.Description);
    }
}
