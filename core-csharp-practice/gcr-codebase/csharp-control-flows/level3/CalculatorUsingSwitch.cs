using System;

class CalculatorUsingSwitch
{
    static void Main()
    {   // declare variables
        double first;

        double second;

        string op;
        //  take input from user
        Console.WriteLine("enter first number");

        first = double.Parse(Console.ReadLine());

        Console.WriteLine("enter second number");

        second = double.Parse(Console.ReadLine());
        //  take operator as input from user
        Console.WriteLine("Enter operator (+, -, *, /):");


        op = Console.ReadLine();
        // perform calculation based on operator
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
