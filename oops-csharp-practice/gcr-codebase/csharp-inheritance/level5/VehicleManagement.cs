using System;

// Base class: Vehicle
class Vehicle
{
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(string model, int maxSpeed)
    {
        this.Model = model;
        this.MaxSpeed = maxSpeed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

// Interface: Refuelable
interface IRefuelable
{
    void Refuel();
}

// Subclass: ElectricVehicle inherits Vehicle
class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; } // in kWh

    public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
        : base(model, maxSpeed)
    {
        this.BatteryCapacity = batteryCapacity;
    }

    // Unique behavior for electric vehicles
    public void Charge()
    {
        Console.WriteLine($"Electric Vehicle {Model} is charging. Battery capacity: {BatteryCapacity} kWh");
    }
}

// Subclass: PetrolVehicle inherits Vehicle and implements IRefuelable
class PetrolVehicle : Vehicle, IRefuelable
{
    public int FuelTankCapacity { get; set; } // in liters

    public PetrolVehicle(string model, int maxSpeed, int fuelTankCapacity)
        : base(model, maxSpeed)
    {
        this.FuelTankCapacity = fuelTankCapacity;
    }

    // Implementation of Refuel
    public void Refuel()
    {
        Console.WriteLine($"Petrol Vehicle {Model} is refueling. Tank capacity: {FuelTankCapacity} liters");
    }
}

// Test program
class Program
{
    static void Main()
    {
        // Electric vehicle
        ElectricVehicle ev = new ElectricVehicle("Tesla Model S", 250, 100);
        ev.DisplayInfo();
        ev.Charge();
        Console.WriteLine();

        // Petrol vehicle
        PetrolVehicle pv = new PetrolVehicle("Toyota Corolla", 180, 50);
        pv.DisplayInfo();
        pv.Refuel();
    }
}
