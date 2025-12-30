using System;
class Book
{
    private string title="Monster";
    private string author="Naoki Kurasawa";
    private double price=1000;
    private bool availability=true;

    public void BorrowBook()
    {
        Console.WriteLine(availability ? "Book Borrowed" : "book is not available");
        availability = !availability;
    }

}

class Program
{
    static void Main()
    {
        Book book = new Book();
        book.BorrowBook();
        book.BorrowBook();

    }
}