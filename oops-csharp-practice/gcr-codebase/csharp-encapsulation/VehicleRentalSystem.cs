using System;
using System.Collections.Generic;
public interface IInsurable  //interface which have two methods to be implemented
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}
public abstract class Vehicle //abstract which is inherited by other classes like Car,Bike,Truck
{ //object variables
    protected int vehicleNumber;
    protected string type;
    protected double rentalRate;

    public Vehicle(int vehicleNumber, string type, double rentalRate) //parameterized constructor
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }
    public abstract double CalculateRentalCost(int days); //abstract method
}

class Car : Vehicle, IInsurable  //extending the Vehicle class and exteding the IInsurable interface
{
    public Car(int vehicleNumber, string type, double rentalRate) : base(vehicleNumber, type, rentalRate) { } //parameterized constructor can doing constructor chaining
    public override double CalculateRentalCost(int days) //abstract method which is calculating rent
    {
        return days * rentalRate;
    }
    public double CalculateInsurance()  //calculating insurance
    {
        return rentalRate * 0.05;
    }
    public string GetInsuranceDetails() 
    {
        return "Insurance of this " + type + " is " + CalculateInsurance();
    }
}

class Bike : Vehicle, IInsurable
{
    public Bike(int vehicleNumber, string type, double rentalRate) : base(vehicleNumber, type, rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * rentalRate;
    }
    public double CalculateInsurance()
    {
        return rentalRate * 0.01;
    }
    public string GetInsuranceDetails()
    {
        return "Insurance of this " + type + " is " + CalculateInsurance();
    }
}

class Truck : Vehicle, IInsurable
{
    public Truck(int vehicleNumber, string type, double rentalRate) : base(vehicleNumber, type, rentalRate) { }
    public override double CalculateRentalCost(int days)
    {
        return days * rentalRate;
    }
    public double CalculateInsurance()
    {
        return rentalRate * 0.1;
    }
    public string GetInsuranceDetails()
    {
        return "Insurance of this " + type + " is " + CalculateInsurance();
    }
}

class Program
{   //entry point
    static void Main()
    {
        List<Vehicle> vehicles=new List<Vehicle>(); //vehicle list 
        Vehicle car = new Car(1, "Car", 1000); //object creating of car class but reference type is vehicle
        Vehicle bike = new Bike(2, "Bike", 500);
        Vehicle Truck = new Truck(3, "Truck", 2000);
        vehicles.Add(car);
        vehicles.Add(bike);
        vehicles.Add(Truck);
        foreach(Vehicle vehicle in vehicles) //interating through each object
        {
            Console.WriteLine(((IInsurable)vehicle).GetInsuranceDetails());
            Console.WriteLine(((IInsurable)vehicle).CalculateInsurance());
            Console.WriteLine(vehicle.CalculateRentalCost(5));
        }


    }
}