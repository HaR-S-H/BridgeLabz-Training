using System;
class Operators
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 3;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);

        // Comparison Operators
        Console.WriteLine("Comparison Operators:");
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);
        Console.WriteLine(a >= b);
        Console.WriteLine(a <= b);

        // Logical Operators
        Console.WriteLine("Logical Operators:");
        bool x = true;
        bool y = false;
        Console.WriteLine(x && y);
        Console.WriteLine(x || y);
        Console.WriteLine(!x);

        // Assignment Operators
        Console.WriteLine("Assignment Operators:");
        int c = a;
        Console.WriteLine(c);
        c += b; 
        Console.WriteLine(c);
        c -= b; 
        Console.WriteLine(c);
        c *= b;
        Console.WriteLine(c);
        c /= b; 
        Console.WriteLine(c);
        c %= b;
        Console.WriteLine(c);

        //is for checking data type
        Console.WriteLine("Type Checking with 'is' Operator:");
        object obj = "Hello";
        if (obj is string)
        Console.WriteLine("obj is a string");

        //unary operator
        Console.WriteLine("Unary Operators:");
        Console.WriteLine(+a);
        Console.WriteLine(-a);

        //ternary operator
        Console.WriteLine("Ternary Operator:");
        string result = (a > b) ? "a is greater than b" : "a is not greater than b";
        Console.WriteLine(result);
        
    }
}