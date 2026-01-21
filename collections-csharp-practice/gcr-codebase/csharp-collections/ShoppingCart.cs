using System;
using System.Collections.Generic;
using System.Collections.Specialized;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();
        OrderedDictionary order = new OrderedDictionary();
        SortedDictionary<double, string> sortedByPrice = new SortedDictionary<double, string>();

        AddItem("Laptop", 75000, cart, order, sortedByPrice);
        AddItem("Mouse", 500, cart, order, sortedByPrice);
        AddItem("Keyboard", 1500, cart, order, sortedByPrice);

        Console.WriteLine("\nCart (Insertion Order):");
        foreach (var key in order.Keys)
            Console.WriteLine(key + " : " + cart[key.ToString()]);

        Console.WriteLine("\nCart (Sorted by Price):");
        foreach (var item in sortedByPrice)
            Console.WriteLine(item.Value + " : " + item.Key);
    }

    static void AddItem(string name, double price,
                        Dictionary<string, double> cart,
                        OrderedDictionary order,
                        SortedDictionary<double, string> sorted)
    {
        cart[name] = price;
        order.Add(name, null);
        sorted[price] = name;
    }
}
