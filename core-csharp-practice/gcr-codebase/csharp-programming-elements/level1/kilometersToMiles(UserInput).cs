using System;

class KilometersToMilesUserInput
{
    static void Main()
    { //take distance in kilometers as input from user
        Console.Write("enter distance");
        
        double km = Convert.ToDouble(Console.ReadLine());

        double miles = km / 1.6;
        //  print the result
        Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
    }
}
