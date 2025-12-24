using System;

class TotalPurchasePrice
{
    static void Main()
    {   //  take unit price and quantity as input from user
        Console.Write("enter unit price");

        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter quantity");

        int quantity = Convert.ToInt32(Console.ReadLine());
        // calculate total purchase price
        double totalPrice = unitPrice * quantity;
        // print the result
        Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity {quantity} and unit price is INR {unitPrice}");
    }
}
