using System;
using System.Collections.Generic;
class Product
{
    public string Name { get; private set; }
    public int Id { get; private set; }
    public double discount { get; private set; }
    public Product(int Id, string Name, double discount)
    {
        this.Id = Id;
        this.Name = Name;
        this.discount = discount;
    }
    public override string ToString()
    {
        return "Product ID: " + Id + ", Name: " + Name + ", Discount: " + discount + "%";
    }
}

class QuickSortUtility
{
    public static void QuickSort(List<Product> products, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = FindPartition(products, low, high);
            QuickSort(products, low, partitionIndex - 1);
            QuickSort(products, partitionIndex + 1, high);
        }
    }
    public static int FindPartition(List<Product> products, int low, int high)
    {
        double pivot = products[low].discount;
        int i = low;
        int j = high;
        while (i < j)
        {
            while (products[i].discount <= pivot && i <= high)
            {
                i++;
            }
            while (products[j].discount > pivot && j >= low)
            {
                j--;
            }
            if (i < j)
            {
                Swap(products, i, j);
            }
        }
        Swap(products, low, j);
        return j;

    }
    public static void Swap(List<Product> products, int i, int j)
    {
        Product temp = products[i];
        products[i] = products[j];
        products[j] = temp;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products =
        new List<Product>()
        {
            new Product(1, "Laptop", 15.5),
            new Product(2, "Smartphone", 10.0),
            new Product(3, "Tablet", 20.0),
            new Product(4, "Monitor", 5.0),
            new Product(5, "Headphones", 8.0),
        };
        Console.WriteLine("Before Sorting:");
        foreach (Product p in products)
        {
            Console.WriteLine(p.ToString());
        }
        QuickSortUtility.QuickSort(products, 0, products.Count - 1);
        Console.WriteLine("\nAfter Sorting by Discount Percentage:");
        foreach (Product p in products)
        {
            Console.WriteLine(p.ToString());
        }

    }
}

