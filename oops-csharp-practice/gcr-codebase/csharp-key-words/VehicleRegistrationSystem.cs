using System;

class Vehicle
{
    public static double RegistrationFee = 2000;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string regNo, string ownerName, string vehicleType)
    {
        this.RegistrationNumber = regNo;
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
    }

    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }

    public void Display(object obj)
    {
        if (obj is Vehicle)
        {
            Console.WriteLine($"RegNo: {RegistrationNumber}, Owner: {OwnerName}, Type: {VehicleType}, Fee: {RegistrationFee}");
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("MH12AB1234", "Harsh", "Car");
        Vehicle.UpdateRegistrationFee(2500);
        v1.Display(v1);
    }
}
