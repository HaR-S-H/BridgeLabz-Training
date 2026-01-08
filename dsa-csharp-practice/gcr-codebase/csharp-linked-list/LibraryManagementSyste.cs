class BookNode
{
    public int BookId;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;
    public BookNode Next;
    public BookNode Prev;

    public BookNode(int id, string title, string author, string genre, bool isAvailable)
    {
        BookId = id;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}
class LibraryDoublyLinkedList
{
    private BookNode head;
    private BookNode tail;

    // Add at Beginning
    public void AddAtBeginning(int id, string title, string author, string genre, bool isAvailable)
    {
        BookNode newNode = new BookNode(id, title, author, genre, isAvailable);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        Console.WriteLine("Book added at beginning.");
    }

    // Add at End
    public void AddAtEnd(int id, string title, string author, string genre, bool isAvailable)
    {
        BookNode newNode = new BookNode(id, title, author, genre, isAvailable);

        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        Console.WriteLine("Book added at end.");
    }

    // Add at Specific Position (1-based)
    public void AddAtPosition(int position, int id, string title, string author, string genre, bool isAvailable)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(id, title, author, genre, isAvailable);
            return;
        }

        BookNode newNode = new BookNode(id, title, author, genre, isAvailable);
        BookNode temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }

        if (temp.Next == null)
        {
            AddAtEnd(id, title, author, genre, isAvailable);
            return;
        }

        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;

        Console.WriteLine("Book added at position " + position);
    }

    // Remove by Book ID
    public void RemoveById(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode temp = head;

        while (temp != null && temp.BookId != id)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        // If head node
        if (temp == head)
        {
            head = head.Next;
            if (head != null)
                head.Prev = null;
            else
                tail = null;
        }
        // If tail node
        else if (temp == tail)
        {
            tail = tail.Prev;
            tail.Next = null;
        }
        // Middle node
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }

        Console.WriteLine("Book removed successfully.");
    }

    // Search by Title
    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found.");
    }

    // Search by Author
    public void SearchByAuthor(string author)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No books found for this author.");
    }

    // Update Availability
    public void UpdateAvailability(int id, bool newStatus)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                temp.IsAvailable = newStatus;
                Console.WriteLine("Availability updated successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found.");
    }

    // Display Forward
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No books in library.");
            return;
        }

        Console.WriteLine("\nBooks (Forward Order):");
        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }

    // Display Reverse
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No books in library.");
            return;
        }

        Console.WriteLine("\nBooks (Reverse Order):");
        BookNode temp = tail;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }

    // Count Total Books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        Console.WriteLine("\nTotal Books in Library: " + count);
    }

    // Helper Method
    private void DisplayBook(BookNode book)
    {
        string status = book.IsAvailable ? "Available" : "Not Available";
        Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Status: {status}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n==== Library Management System ====");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Book ID");
            Console.WriteLine("5. Search by Title");
            Console.WriteLine("6. Search by Author");
            Console.WriteLine("7. Update Availability");
            Console.WriteLine("8. Display Forward");
            Console.WriteLine("9. Display Reverse");
            Console.WriteLine("10. Count Books");
            Console.WriteLine("11. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int id, position;
            string title, author, genre;
            bool isAvailable;

            switch (choice)
            {
                case 1:
                    ReadBook(out id, out title, out author, out genre, out isAvailable);
                    library.AddAtBeginning(id, title, author, genre, isAvailable);
                    break;

                case 2:
                    ReadBook(out id, out title, out author, out genre, out isAvailable);
                    library.AddAtEnd(id, title, author, genre, isAvailable);
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    position = Convert.ToInt32(Console.ReadLine());
                    ReadBook(out id, out title, out author, out genre, out isAvailable);
                    library.AddAtPosition(position, id, title, author, genre, isAvailable);
                    break;

                case 4:
                    Console.Write("Enter Book ID to Remove: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    library.RemoveById(id);
                    break;

                case 5:
                    Console.Write("Enter Book Title: ");
                    title = Console.ReadLine();
                    library.SearchByTitle(title);
                    break;

                case 6:
                    Console.Write("Enter Author Name: ");
                    author = Console.ReadLine();
                    library.SearchByAuthor(author);
                    break;

                case 7:
                    Console.Write("Enter Book ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is Available? (true/false): ");
                    isAvailable = Convert.ToBoolean(Console.ReadLine());
                    library.UpdateAvailability(id, isAvailable);
                    break;

                case 8:
                    library.DisplayForward();
                    break;

                case 9:
                    library.DisplayReverse();
                    break;

                case 10:
                    library.CountBooks();
                    break;

                case 11:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 11);
    }

    static void ReadBook(out int id, out string title, out string author, out string genre, out bool isAvailable)
    {
        Console.Write("Book ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Title: ");
        title = Console.ReadLine();
        Console.Write("Author: ");
        author = Console.ReadLine();
        Console.Write("Genre: ");
        genre = Console.ReadLine();
        Console.Write("Is Available (true/false): ");
        isAvailable = Convert.ToBoolean(Console.ReadLine());
    }
}
