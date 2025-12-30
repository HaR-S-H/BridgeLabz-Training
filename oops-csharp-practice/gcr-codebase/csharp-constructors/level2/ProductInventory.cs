using System;
class Product
{   //instance varibles
    private string productName;
    private double price;
    //static because it is common to all the objects
    private static int totalProducts = 0;
    public Product(string productName,double price) //parameterized constructor
    {
        this.price = price;
        this.productName = productName;
        totalProducts++; //increase total products whenver new product is added
    }
    public static void DisplayTotalProducts() //method to show all the number of products
    {
        Console.WriteLine("Total Products :- " + totalProducts);
    }
    public void DisplayProductDetails() //method to show product details
    {
        Console.WriteLine("Products Details :- ");
        Console.WriteLine("Product Name :- " + productName);
        Console.WriteLine("Price :- " + price);
    }
}

class Program
{ //entry point
    static void Main()
    {   //object creation
        Product product1 = new Product("bellavita", 100); //new product is created and we call parameterized constructor
        product1.DisplayProductDetails(); //here we have shown product details of a product
        Product product2 = new Product("denver", 100);
        product2.DisplayProductDetails();
        Product.DisplayTotalProducts(); //here we have shown total products which is common for all objects
    }
}