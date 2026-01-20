using System;

// Base Product
abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - ₹{Price}";
    }
}

// Categories
class Book : Product { }
class Clothing : Product { }

class Marketplace
{
    // Generic method
    public static void ApplyDiscount<T>(T product, double percentage)
        where T : Product
    {
        product.Price -= product.Price * (percentage / 100);
    }
}

// Usage
class Program
{
    static void Main()
    {
        Book book = new Book { Name = "C# in Depth", Price = 800 };
        Marketplace.ApplyDiscount(book, 10);

        Console.WriteLine(book);
    }
}
