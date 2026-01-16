class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}";
    }

    public override bool Equals(object obj)
    {
        Book b = obj as Book;
        return b != null && Title == b.Title && Author == b.Author;
    }

    public override int GetHashCode()
    {
        return (Title + Author).GetHashCode();
    }
}
