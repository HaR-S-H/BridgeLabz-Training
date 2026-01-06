using System;
using System.Collections.Generic;

// Interface
public interface ITaxable
{
    double CalculateTax();
}

// Abstract Class
public abstract class Product
{
    // Encapsulation
    private int productId;
    private string name;
    private double price;

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public Product(int id, string name, double price)
    {
        ProductId = id;
        Name = name;
        Price = price;
    }

    // Abstract Method
    public abstract double CalculateDiscount();
}

// Electronics (Tax + Discount)
public class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10;   // 10% discount
    }

    public double CalculateTax()
    {
        return Price * 0.18;   // 18% tax
    }
}

// Clothing (Tax + Discount)
public class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20;   // 20% discount
    }

    public double CalculateTax()
    {
        return Price * 0.05;   // 5% tax
    }
}

// Groceries (Only Discount, No Tax)
public class Groceries : Product
{
    public Groceries(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05;   // 5% discount
    }
}

// Program
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Electronics(1, "Laptop", 60000),
            new Clothing(2, "Shirt", 2000),
            new Groceries(3, "Rice", 1000)
        };

        foreach (Product p in products)
        {
            double discount = p.CalculateDiscount();
            double tax = 0;

            if (p is ITaxable t)
            {
                tax = t.CalculateTax();
            }

            double finalPrice = p.Price + tax - discount;

            Console.WriteLine(p.Name);
            Console.WriteLine("Price: " + p.Price);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine("-------------------");
        }
    }
}
