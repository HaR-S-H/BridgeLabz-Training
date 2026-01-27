using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello(string name);
}

public class Greeting : IGreeting
{
    public void SayHello(string name) => Console.WriteLine($"Hello, {name}");
}

public class LoggingProxy : DispatchProxy
{
    public IGreeting Target;

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"Calling method: {targetMethod.Name}");
        return targetMethod.Invoke(Target, args);
    }
}
