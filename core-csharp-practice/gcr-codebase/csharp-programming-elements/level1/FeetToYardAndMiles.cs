using System;

class FeetToYardAndMiles
{
    static void Main()
    {   //take distance in feet as input from user
        Console.Write("enter distance");

        double feet = Convert.ToDouble(Console.ReadLine());
        //convert feet to yards and miles
        double yards = feet / 3;
        double miles = yards / 1760;
        //print distance in yards and miles
        Console.WriteLine($"Distance in yards is {yards} and miles is {miles}");
    }
}
