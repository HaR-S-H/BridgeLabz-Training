using System;

class Product
{
    public static double Discount = 10;   // shared by all products
    private static int counter = 1;

    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(string productName, double price, int quantity)
    {
        this.ProductID = counter++;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public void Display(object obj)
    {
        if (obj is Product)
        {
            Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Qty: {Quantity}, Discount: {Discount}%");
        }
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 50000, 1);
        Product.UpdateDiscount(15);
        p1.Display(p1);
    }
}
