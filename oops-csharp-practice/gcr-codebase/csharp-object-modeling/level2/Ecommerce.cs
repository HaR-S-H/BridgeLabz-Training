using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

class Order
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void ShowOrder()
    {
        foreach (var p in Products)
            Console.WriteLine(p.Name + " - " + p.Price);
    }
}

class Customer
{
    public string Name;

    public Customer(string name)
    {
        Name = name;
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine(Name + " placed an order");
        order.ShowOrder();
    }
}
class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 50000.0);
        Product p2 = new Product("Mobile", 10000.0);
        Order order = new Order();
        order.AddProduct(p1);
        order.AddProduct(p2);
        Customer customer = new Customer("Ujjwal");
        customer.PlaceOrder(order);
    }
}