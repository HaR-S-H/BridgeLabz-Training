using System;

class BusRouteTracker
{
    static void Main()
    {
        int totalDistance = 0;
        int distancePerStop = 5;   // each stop adds 5 km
        string choice = "";

        while (true)
        {
            totalDistance += distancePerStop;
            Console.WriteLine("Bus reached next stop.");
            Console.WriteLine("Distance covered: " + totalDistance + " km");

            Console.Write("Do you want to get off here? (yes/no): ");
            choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                Console.WriteLine("You got off the bus.");
                Console.WriteLine("Total distance travelled: " + totalDistance + " km");
                break;
            }
        }

        Console.ReadLine();
    }
}
