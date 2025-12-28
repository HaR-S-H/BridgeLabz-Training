using System;

class Calculator
{
    static int Add(int a, int b) { return a + b; }
    static int Sub(int a, int b) { return a - b; }
    static int Mul(int a, int b) { return a * b; }
    static int Div(int a, int b) { return a / b; }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("1.Add 2.Subtract 3.Multiply 4.Divide");
        Console.Write("Choose operation: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine("Result: " + Add(a, b));
        else if (choice == 2)
            Console.WriteLine("Result: " + Sub(a, b));
        else if (choice == 3)
            Console.WriteLine("Result: " + Mul(a, b));
        else if (choice == 4)
            Console.WriteLine("Result: " + Div(a, b));
        else
            Console.WriteLine("Invalid choice");
    }
}
