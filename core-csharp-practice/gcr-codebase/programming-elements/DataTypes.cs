using System;
class DataTypes
{
    static void Main(string[] args)
    {
        // Integer data type
        int integerVar= 42;
        Console.WriteLine("Integer: " + integerVar);

        // Floating-point data type
        float floatVar = 3.14f;
        Console.WriteLine("Float: " + floatVar);

        // Double data type
        double doubleVar = 3.14159265359;
        Console.WriteLine("Double: " + doubleVar);

        // Character data type
        char charVar = 'A';
        Console.WriteLine("Character: " + charVar);

        // String data type
        string stringVar = "Hello, World!";
        Console.WriteLine("String: " + stringVar);

        // Boolean data type
        bool boolVar = true;
        Console.WriteLine("Boolean: " + boolVar);

        //implicitly type conversion
        int intVar = 100;
        double implicitDoubleVar = intVar;
        Console.WriteLine("Implicitly converted double: " + implicitDoubleVar);
        //explicitly type conversion
        double doubleVar2 = 9.78;
        int explicitIntVar = (int)doubleVar2;
        Console.WriteLine("Explicitly converted integer: " + explicitIntVar);
        
    }
}