using System;

class SidepOfSquare
{
    static void Main()
    {       //take perimeter of square as input from user
        Console.Write("enter perimeter of square");

        //calculate side of square
            double perimeter = Convert.ToDouble(Console.ReadLine());
        //side = perimeter / 4
        double side = perimeter / 4;
        //print the result
        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }
}
