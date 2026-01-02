using System;
class Book
{   //class variables
    public readonly static string libraryName = "ABC Library";
    public string title;
    public string author;
    public readonly int isbn;
    public Book(string title, string author, int isbn) //parameterized constructor
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }
    public static void DisplayLibraryName() //static method to display library name
    {
        Console.WriteLine(libraryName);
    }
    public void DisplayDetails() //method to display book details
    {
        Console.WriteLine("Book Details :- ");
        Console.WriteLine("Title :- " + title);
        Console.WriteLine("Author :- " + author);
        Console.WriteLine("Isbn :- " + isbn);
    }

}

class Program
{
    static void Main()
    {
        Book book = new Book("freedom", "eren", 1); //object creation
        if(book is Book) //checking type of object
        book.DisplayDetails(); //calling method
    }
}