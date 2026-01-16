using System.Collections.Generic;

class LibraryMana
{
    private Dictionary<string, LinkedList<Book>> catalog;
    private HashSet<Book> uniqueBooks;

    public LibraryManager()
    {
        catalog = new Dictionary<string, LinkedList<Book>>();
        uniqueBooks = new HashSet<Book>();
    }

    public void AddBook(string genre, string title, string author)
    {
        Book book = new Book(title, author);

        if (uniqueBooks.Contains(book))
        {
            Console.WriteLine("Duplicate book! Not added.");
            return;
        }

        if (!catalog.ContainsKey(genre))
            catalog[genre] = new LinkedList<Book>();

        catalog[genre].AddLast(book);
        uniqueBooks.Add(book);
        Console.WriteLine("Book added.");
    }

    public void RemoveBook(string genre, string title, string author)
    {
        if (!catalog.ContainsKey(genre))
        {
            Console.WriteLine("Genre not found.");
            return;
        }

        Book book = new Book(title, author);
        if (catalog[genre].Remove(book))
        {
            uniqueBooks.Remove(book);
            Console.WriteLine("Book removed.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public override string ToString()
    {
        if (catalog.Count == 0)
            return "Library is empty.";

        string result = "Library Catalog:\n";
        foreach (var genre in catalog)
        {
            result += $"Genre: {genre.Key}\n";
            foreach (var book in genre.Value)
                result += "  - " + book + "\n";
        }
        return result;
    }
}
