using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.Write("Enter method (Add/Subtract/Multiply): ");
        string methodName = Console.ReadLine();

        var obj = new MathOperations();
        MethodInfo method = typeof(MathOperations).GetMethod(methodName);

        object result = method.Invoke(obj, new object[] { 10, 5 });
        Console.WriteLine("Result: " + result);
    }
}
