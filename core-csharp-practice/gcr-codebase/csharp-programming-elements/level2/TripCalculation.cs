using System;

class TripCalculation
{
    static void Main()
    {   // take trip details as input from user
        Console.Write("enter name");

        string name = Console.ReadLine();
        //From City
        Console.Write("from city");


        string fromCity = Console.ReadLine();
        //Via City
        Console.Write("via city");

        string viaCity = Console.ReadLine();

        Console.Write("To City: ");
        string toCity = Console.ReadLine();

        Console.Write("Distance from start to via");


        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Distance from via to final city");


        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Time taken (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());
        // calculate total distance and speed
        double totalDistance = fromToVia + viaToFinalCity;
        
        
        double speed = totalDistance / timeTaken;

        Console.WriteLine($"The results of the trip are Distance: {totalDistance}, Time: {timeTaken}, Speed: {speed}");
    }
}
