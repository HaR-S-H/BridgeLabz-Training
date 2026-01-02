using System;
class Book
{   //instance variables
    public int isbn;
    protected string title;
    private string author;
    public Book(int isbn, string title, string author) //parameterized constructor
    {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
    }
    public string GetAuthorName() //method to get author name
    {
      return author;
    }
    public void SetAuthorName(string authorName) //method to set author name 
    {
        author = authorName;
    }

}

class EBook : Book //inheritance
{
    public EBook(int isbn, string title, string author) : base(isbn, title, author) { } //parameterized constructor
    public void DisplayDetails() //method to display details
    {
        Console.WriteLine("E-Book Details :- ");
        Console.WriteLine("Title :- " + title);
        Console.WriteLine("Isbn :- " + isbn);
        Console.WriteLine("Author :- " + GetAuthorName());
    }
}

class Program
{   //entry point
    static void Main()
    {
        EBook ebook = new EBook(1, "freedom", "eren"); //object creation
        ebook.DisplayDetails(); //calling method to display details
    }
}