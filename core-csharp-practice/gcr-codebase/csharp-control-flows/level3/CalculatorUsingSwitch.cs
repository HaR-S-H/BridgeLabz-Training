using System;

class CalculatorUsingSwitch
{
    static void Main()
    {
        double first;
        double second;
        string op;

        Console.WriteLine("Enter first number:");
        first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /):");
        op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Result = " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result = " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result = " + (first * second));
                break;

            case "/":
                Console.WriteLine("Result = " + (first / second));
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
