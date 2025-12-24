using System;

class PoundToKilogram
{
    static void Main()
    {   //  take weight in pounds as input from user
        Console.Write("enter weight");
        double pounds = Convert.ToDouble(Console.ReadLine());
    // convert pounds to kilograms
        double kg = pounds / 2.2;
    // print weight in both units
        Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kg}");
    }
}
