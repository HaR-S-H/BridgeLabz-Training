using System; 
class Book
{
    private string title;
    private string author;
    private int price;
    public Book(string title, string author, int price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Book Details :- ");
        Console.WriteLine("Title :- " + title);
        Console.WriteLine("Author :- " + author);
        Console.WriteLine("Price :- " + price);
    }
}

class program {
    static void Main()
    {
        Book book1 = new Book("freedom", "eren", 1000);
        Book book2 = new Book("Monster", "naoki kurasawa", 1000);
        book1.DisplayDetails();
        book2.DisplayDetails();
    }
}
