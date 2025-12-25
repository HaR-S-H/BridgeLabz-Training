using System;

class UnitConvertor
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kg = 0.453592;
        return pounds * pounds2kg;
    }

    public static double ConvertKilogramsToPounds(double kg)
    {
        double kg2pounds = 2.20462;
        return kg * kg2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    static void Main()
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Fahrenheit = " + ConvertCelsiusToFahrenheit(c));

        Console.WriteLine("Enter weight in kg:");
        double kg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Pounds = " + ConvertKilogramsToPounds(kg));
    }
}
