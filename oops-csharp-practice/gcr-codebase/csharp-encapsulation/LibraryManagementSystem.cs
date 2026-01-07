using System;
public interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}

public abstract class LibraryItem : IReservable
{
    // Encapsulated fields
    private int itemId;
    private string title;
    private string author;

    // Borrower details (encapsulated)
    private string borrowerName;
    private bool isReserved;

    public LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
        this.isReserved = false;
    }

    // Abstract method
    public abstract int GetLoanDuration();

    // Concrete method
    public void GetItemDetails()
    {
        Console.WriteLine($"ID: {itemId}, Title: {title}, Author: {author}");
    }

    // Interface methods
    public void ReserveItem(string borrowerName)
    {
        if (!isReserved)
        {
            this.borrowerName = borrowerName;
            isReserved = true;
            Console.WriteLine($"{title} has been reserved by {borrowerName}");
        }
        else
        {
            Console.WriteLine($"{title} is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return !isReserved;
    }

    // Encapsulation: Access borrower details safely
    protected string GetBorrower()
    {
        return borrowerName;
    }
}

public class Book : LibraryItem
{
    public Book(int id, string title, string author) : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // 14 days
    }
}

public class Magazine : LibraryItem
{
    public Magazine(int id, string title, string author) : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 7 days
    }
}
public class DVD : LibraryItem
{
    public DVD(int id, string title, string author) : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // 3 days
    }
}
class Program
{
    static void Main()
    {
        // Polymorphism: base class reference for different objects
        LibraryItem item1 = new Book(101, "C# Programming", "Microsoft");
        LibraryItem item2 = new Magazine(102, "Tech Monthly", "Tech Media");
        LibraryItem item3 = new DVD(103, "Inception", "Christopher Nolan");

        // Display details
        item1.GetItemDetails();
        Console.WriteLine("Loan Duration: " + item1.GetLoanDuration() + " days\n");

        item2.GetItemDetails();
        Console.WriteLine("Loan Duration: " + item2.GetLoanDuration() + " days\n");

        item3.GetItemDetails();
        Console.WriteLine("Loan Duration: " + item3.GetLoanDuration() + " days\n");

        // Reservation system
        item1.ReserveItem("Harsh Gupta");
        Console.WriteLine("Available: " + item1.CheckAvailability());

        item1.ReserveItem("Another User"); // Should show already reserved
    }
}
