using System;

class TripCalculation
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("From City: ");
        string fromCity = Console.ReadLine();

        Console.Write("Via City: ");
        string viaCity = Console.ReadLine();

        Console.Write("To City: ");
        string toCity = Console.ReadLine();

        Console.Write("Distance from start to via (miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Distance from via to final city (miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Time taken (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double speed = totalDistance / timeTaken;

        Console.WriteLine($"The results of the trip are Distance: {totalDistance}, Time: {timeTaken}, Speed: {speed}");
    }
}
