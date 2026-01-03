using System;
using System.Collections.Generic;
class Library
{   //instance variable
    public string libraryName;
    public List<Book> books;
    public Library(string libraryName)
    {
        books = new List<Book>();
        this.libraryName = libraryName;
    }
    public void AddBook(Book book) //method to add book
    {
        books.Add(book);
    }
    public void DisplayBooks() //method to display books
    {
        foreach(Book book in books) //printing each book details
        {
            Console.WriteLine("Book Details :- ");
            Console.WriteLine(book.Title);
            Console.WriteLine(book.author);
        }
    }
}

class Book
{   //instance variable
    public string Title;
    public string author;
    public Book(string Title,string author) //parameterized constructor
    {
        this.Title = Title;
        this.author = author;
    }
}

class Program
{
    static void Main()
    {
        Library library1 = new Library("Library1"); //creating object of library class
        Library library2 = new Library("Library2"); //creating object of library class
        Book book1=new Book("Attack On Titan","Naoki kurasawa"); //creating object of book class
        Book book2 = new Book("freedom", "eren"); //creating object of book class
        library1.AddBook(book1); //adding book1 to library1
        library2.AddBook(book2); //adding book2 to library2
        library1.DisplayBooks(); //displaying books of library1
        library2.DisplayBooks(); //displaying books of library2
    }
}
