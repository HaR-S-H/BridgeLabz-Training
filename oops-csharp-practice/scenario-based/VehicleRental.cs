using System;
public interface IRentable
{
   double CalculateRent(int days);
}


public abstract class Vehicle : IRentable
{
    protected string VehicleNumber;
    protected double RatePerDay;

    public Vehicle(string number, double rate)
    {
        VehicleNumber = number;
        RatePerDay = rate;
    }

    public abstract double CalculateRent(int days);
}

public class Bike : Vehicle
{
    public Bike(string number) : base(number, 500) { }

    public override double CalculateRent(int days)
    {
        return days * RatePerDay;
    }
}


public class Car : Vehicle
{
    public Car(string number) : base(number, 1200) { }

    public override double CalculateRent(int days)
    {
        return days * RatePerDay;
    }
}


public class Truck : Vehicle
{
    public Truck(string number) : base(number, 2500) { }

    public override double CalculateRent(int days)
    {
        return days * RatePerDay;
    }
}

public class Customer
{
    public string Name { get; set; }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        Console.WriteLine(Name+" Rent Amount: ₹"+vehicle.CalculateRent(days));
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer { Name = "Harsh" };

        Vehicle bike = new Bike("BIKE101");
        Vehicle car = new Car("CAR202");
        Vehicle truck = new Truck("TRUCK303");

        customer.RentVehicle(bike, 3);
        customer.RentVehicle(car, 5);
        customer.RentVehicle(truck, 2);
    }
}
