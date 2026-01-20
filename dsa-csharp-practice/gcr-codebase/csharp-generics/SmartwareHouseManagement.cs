using System;
using System.Collections.Generic;

// Base class
abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public abstract string Category { get; }

    public override string ToString()
    {
        return $"{Category} - {Name} (Qty: {Quantity})";
    }
}

// Derived classes
class Electronics : WarehouseItem
{
    public override string Category => "Electronics";
}

class Groceries : WarehouseItem
{
    public override string Category => "Groceries";
}

class Furniture : WarehouseItem
{
    public override string Category => "Furniture";
}

// Generic Storage
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

// Usage
class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics { Name = "Laptop", Quantity = 10 });

        electronicsStorage.DisplayItems();
    }
}
