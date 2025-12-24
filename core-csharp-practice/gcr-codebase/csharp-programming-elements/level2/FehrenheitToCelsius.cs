using System;

class FehrenheitToCelsius
{
    static void Main()
    { //take temperature in fahrenheit as input from user
        Console.Write("enter temperature");

        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        //convert fahrenheit to celsius
        double celsius = (fahrenheit - 32) * 5 / 9;
        //print temperature in celsius
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsius} Celsius");
    }
}
