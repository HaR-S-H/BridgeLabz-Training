using System;

class AtheleteRounds
{
    static void Main()
    {   //take the three sides of the track as input from user
        Console.Write("enter side1");
        double s1 = Convert.ToDouble(Console.ReadLine());
        //side2
        Console.Write("enter side2");
        double s2 = Convert.ToDouble(Console.ReadLine());
        //side3
        Console.Write("Enter side3");
        double s3 = Convert.ToDouble(Console.ReadLine());
        //calculate perimeter and number of rounds in 5 km
        double perimeter = s1 + s2 + s3;
        double rounds = 5000 / perimeter;
        //  print the result
        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
    }
}
