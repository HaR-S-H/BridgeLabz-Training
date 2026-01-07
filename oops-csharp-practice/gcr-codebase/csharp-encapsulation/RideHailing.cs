using System;
public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}


public abstract class Vehicle : IGPS
{
    // Encapsulation: private fields
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    private string currentLocation;

    public Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
        this.currentLocation = "Unknown";
    }

    // Protected accessor for subclasses
    protected double GetRatePerKm()
    {
        return ratePerKm;
    }

    // Abstract method
    public abstract double CalculateFare(double distance);

    // Concrete method
    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
        Console.WriteLine("Rate Per Km: " + ratePerKm);
        Console.WriteLine("Current Location: " + currentLocation);
    }

    // Interface methods
    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
        Console.WriteLine("Location updated to: " + currentLocation);
    }
}
public class Car : Vehicle
{
    public Car(int id, string driver, double rate)
        : base(id, driver, rate)
    {
    }

    public override double CalculateFare(double distance)
    {
        double total = distance * GetRatePerKm();
        return total;
    }
}
public class Bike : Vehicle
{
    public Bike(int id, string driver, double rate)
        : base(id, driver, rate)
    {
    }

    public override double CalculateFare(double distance)
    {
        double total = distance * GetRatePerKm() * 0.8; // cheaper rides
        return total;
    }
}

public class Auto : Vehicle
{
    public Auto(int id, string driver, double rate)
        : base(id, driver, rate)
    {
    }

    public override double CalculateFare(double distance)
    {
        double total = distance * GetRatePerKm() * 1.2; // slightly higher charges
        return total;
    }
}

public class RideService
{
    public void ProcessRide(Vehicle vehicle, double distance)
    {
        Console.WriteLine("---- Ride Details ----");
        vehicle.GetVehicleDetails();
        Console.WriteLine("Distance: " + distance);
        Console.WriteLine("Total Fare: " + vehicle.CalculateFare(distance));
        Console.WriteLine();
    }
}



class Program
{
    static void Main()
    {
        Vehicle car = new Car(201, "Rohit", 15);
        Vehicle bike = new Bike(202, "Amit", 10);
        Vehicle auto = new Auto(203, "Suresh", 12);

        car.UpdateLocation("MG Road");
        bike.UpdateLocation("Station");
        auto.UpdateLocation("City Center");

        RideService service = new RideService();

        service.ProcessRide(car, 10);
        service.ProcessRide(bike, 10);
        service.ProcessRide(auto, 10);
    }
}

