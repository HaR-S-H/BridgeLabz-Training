using System;

class AreaOfTriangle
{
    static void Main()
    {   //take base and height as input from user
        Console.Write("Enter base");

        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height");

        double height = Convert.ToDouble(Console.ReadLine());
        //calculate area in square inches
        double areaInInches = 0.5 * baseValue * height;
        //convert area to square centimeters
        double areaInCm = areaInInches * Math.Pow(2.54, 2);
        //print area in both units
        Console.WriteLine($"Area of triangle is {areaInInches} square inches and {areaInCm} square centimeters");
    }
}
