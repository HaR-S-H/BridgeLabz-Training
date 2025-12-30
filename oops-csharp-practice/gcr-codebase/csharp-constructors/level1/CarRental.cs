using System;
class CarRental
{//instance variable
    private string customerName;
    private string carModel;
    private int retalDays;
    //parameterized constructor
    public CarRental(string customerName, string carModel, int retalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.retalDays = retalDays;
    }
    //method for calculating cost
    public void CalculateCost()
    {
        Console.Write("Total Cost :- " + 100 * retalDays);
    }
}
class Program
{//entry point
    static void Main()
    {   //object creation
        CarRental car = new CarRental("harsh", "xuv700", 2); //calling p
        car.CalculateCost();
    }
}