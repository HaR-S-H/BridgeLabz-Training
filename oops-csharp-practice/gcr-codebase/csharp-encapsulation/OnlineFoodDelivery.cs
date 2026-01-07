using System;
public interface IDiscountable
{
    void ApplyDiscount(double discountPercentage);
    string GetDiscountDetails();
}


public abstract class FoodItem : IDiscountable
{
    // Encapsulation: private fields
    private string itemName;
    private double price;
    private int quantity;
    protected double discount;

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
        this.discount = 0;
    }

    // Abstract method
    public abstract double CalculateTotalPrice();

    // Concrete method
    public void GetItemDetails()
    {
        Console.WriteLine("Item Name: " + itemName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Quantity: " + quantity);
    }

    // Interface methods
    public void ApplyDiscount(double discountPercentage)
    {
        discount = discountPercentage;
    }

    public string GetDiscountDetails()
    {
        return "Discount Applied: " + discount + "%";
    }

    // Protected access for subclasses
    protected double GetPrice()
    {
        return price;
    }

    protected int GetQuantity()
    {
        return quantity;
    }
}

public class VegItem : FoodItem
{
    public VegItem(string name, double price, int quantity)
        : base(name, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        double basePrice = GetPrice() * GetQuantity();
        double discountAmount = basePrice * discount / 100;
        return basePrice - discountAmount;
    }
}
public class NonVegItem : FoodItem
{
    private double extraCharge = 50; // additional charge for non-veg items

    public NonVegItem(string name, double price, int quantity)
        : base(name, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        double basePrice = (GetPrice() * GetQuantity()) + extraCharge;
        double discountAmount = basePrice * discount / 100;
        return basePrice - discountAmount;
    }
}


class Program
{
    static void Main()
    {
        // Polymorphism: base class reference
        FoodItem item1 = new VegItem("Paneer Burger", 120, 2);
        FoodItem item2 = new NonVegItem("Chicken Pizza", 300, 1);

        Console.WriteLine("---- Veg Item ----");
        item1.GetItemDetails();
        item1.ApplyDiscount(10);
        Console.WriteLine(item1.GetDiscountDetails());
        Console.WriteLine("Total Price: " + item1.CalculateTotalPrice());

        Console.WriteLine();

        Console.WriteLine("---- Non-Veg Item ----");
        item2.GetItemDetails();
        item2.ApplyDiscount(5);
        Console.WriteLine(item2.GetDiscountDetails());
        Console.WriteLine("Total Price: " + item2.CalculateTotalPrice());
    }
}
