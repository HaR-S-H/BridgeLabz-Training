using System;
using System.Collections;

public class BookUtility: IBookManager
{
    private ArrayList books = new ArrayList();
    public void AddBook(string title, string author)
    {
        Book book = new Book();
        book.Title = title;
        book.Author = author;
        books.Add(book);
        Console.WriteLine("Book Added Successfully");
    }
    public void SortBooksAlphabetically()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books to sort");
            return;
        }
        for (int i = 0; i < books.Count; i++)
        {
            for (int j = i + 1; j < books.Count; j++)
            {
                Book book1 = (Book)books[i];
                Book book2 = (Book)books[j];
                if (string.Compare(book1.Title, book2.Title) > 0)
                {
                    object temp = books[i];
                    books[i] = books[j];
                    books[j] = temp;
                }
            }
        }
        Console.WriteLine("Books Sorted Successfully");
    }
    public void SearchByAuthor(string author)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books to search");
            return;
        }
        bool found = false;
        Console.WriteLine("Books by " + author + ":");
        foreach (Book book in books)
        {
            string data = book.ToString();
            string[] parts = data.Split('-');
            if (parts.Length == 2)
            {
                string bookAuthor = parts[1].Trim();
                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(data);
                    found = true;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No books found by " + author);
        }
    }
    public string[] ExportToArray()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books to export");
            return new string[0];
        }
        string[] bookArray = new string[books.Count];
        for (int i = 0; i < books.Count; i++)
        {
            Book book = (Book)books[i];
            bookArray[i] = book.ToString();
        }
        Console.WriteLine("Books Exported Successfully");
        return bookArray;

        }
    

}