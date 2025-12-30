using System;
class CarRental
{
    private string customerName;
    private string carModel;
    private int retalDays;

    public CarRental(string customerName, string carModel, int retalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.retalDays = retalDays;
    }
    public void CalculateCost()
    {
        Console.Write("Total Cost :- " + 100 * retalDays);
    }
}
class Program
{
    static void Main()
    {
        CarRental car = new CarRental("harsh", "xuv700", 2);
        car.CalculateCost();
    }
}