using System;

class CelsiusToFehrenheit
{
    static void Main()
    {   //take temperature in celsius as input from user
        Console.Write("enter temperature");

        //convert celsius to fahrenheit
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        //print temperature in fahrenheit
        Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
    }
}
