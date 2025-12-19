using System;

class AreaOfTriangle
{
    static void Main()
    {
        Console.Write("Enter base in inches: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in inches: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double areaInInches = 0.5 * baseValue * height;
        double areaInCm = areaInInches * Math.Pow(2.54, 2);

        Console.WriteLine($"Area of triangle is {areaInInches} square inches and {areaInCm} square centimeters");
    }
}
