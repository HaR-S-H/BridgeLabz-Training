using System;

class BasicCalculator
{
    static void Main()
    { //take height in cm as input from user
        Console.Write("enter height");

        double cm = Convert.ToDouble(Console.ReadLine());

        //convert cm to feet and inches
        double inches = cm / 2.54;
        
        int feet = (int)(inches / 12);

        double remainingInches = inches % 12;
        //print height in feet and inches
        Console.WriteLine($"Your Height in cm is {cm} while in feet is {feet} and inches is {remainingInches}");
    }
}
