using System;

// Superclass
class Book
{
    public string Title;
    public int PublicationYear;

    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    // Virtual method
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

// Subclass
class Author : Book
{
    public string Name;
    public string Bio;

    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    // Override method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);
    }
}

// Program class
class Program
{
    static void Main()
    {
        Book book = new Author(
            "C# Fundamentals",
            2024,
            "Harsh Gupta",
            "Software Developer and C# Enthusiast"
        );

        book.DisplayInfo();
    }
}
