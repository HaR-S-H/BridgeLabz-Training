using System;
class Vehicle
{   //class variables
    private static int registrationFees = 1000;
    //instace variables
    private string ownerName;
    private string vehicleType;
    public Vehicle(string ownerName, string vehicleType) //parameterized constructor
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }
    public void DisplayVehicleDetails() //method for showing details of vehicle
    {
        Console.WriteLine("Vehicle Details :- ");
        Console.WriteLine("Owner Name :- " + ownerName);
        Console.WriteLine("Vehicle Type :- " + vehicleType);
        Console.WriteLine("RegistrationFees :- " + registrationFees);
    }
    public static void UpdateRegistrationFee(int registrationFees) //method for updating registration fees
    {
        Vehicle.registrationFees = registrationFees;
    }
}

class Program
{   //entry point
    static void Main()
    {
        Vehicle vehicle = new Vehicle("harsh", "xuv"); //vehicle object for calling parameterized constructor
        vehicle.DisplayVehicleDetails();  //showing vehicle details
        Vehicle.UpdateRegistrationFee(2000); //updating registration fees
        vehicle.DisplayVehicleDetails(); //showing vehicle details with updated registration fees
    }
}