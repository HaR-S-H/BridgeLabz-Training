using System;
class Book
{
    //instance variables
    private string title;
    private string author;
    private double price;
    //default constructor
    public Book()
    {
        this.title = "Monster";
        this.author = "naoki kurasawa";
        this.price = 1000;
    }
    //parameterized constructors
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    //display details of an object
    public  void DisplayDetails()
    {
        Console.WriteLine("Book Details :- ");
        Console.WriteLine("Title :- " + title);
        Console.WriteLine("Author :- " + author);
        Console.WriteLine("Price :- " + price);
    }
}

class Program
{
    //entry point
    static void Main()
    {   //object creation
        Book book1 = new Book(); //calling default constructor
        Book book2 = new Book("Attack On Titan", "Naoki kurasawa", 1000); //calling parameterized constructor
        book1.DisplayDetails(); //showing details of book1
        book2.DisplayDetails(); //showing details of book2
    }
}