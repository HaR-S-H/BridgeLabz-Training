using System;

class LibraryManagement
{
    static string[] titles = {
        "C Sharp Basics",
        "Dot Net Fundamentals",
        "Data Structures",
        "Operating Systems",
        "Database Management"
    };

    static string[] authors = {
        "John",
        "Mark",
        "Alice",
        "Robert",
        "James"
    };

    static bool[] isAvailable = {
        true,
        true,
        true,
        true,
        true
    };

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Library Management System ---");
            Console.WriteLine("1. Display All Books");
            Console.WriteLine("2. Search Book by Title");
            Console.WriteLine("3. Checkout Book");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                DisplayBooks();
            else if (choice == 2)
                SearchBook();
            else if (choice == 3)
                CheckoutBook();
            else if (choice == 4)
                Console.WriteLine("Exiting...");
            else
                Console.WriteLine("Invalid choice");

        } while (choice != 4);
    }

    static void DisplayBooks()
    {
        Console.WriteLine("\nAvailable Books:");
        for (int i = 0; i < titles.Length; i++)
        {
            string status = isAvailable[i] ? "Available" : "Checked Out";
            Console.WriteLine((i + 1) + ". " + titles[i] + " by " + authors[i] + " - " + status);
        }
    }

    static void SearchBook()
    {
        Console.Write("\nEnter part of book title to search: ");
        string searchText = Console.ReadLine().ToLower();
        bool found = false;

        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].ToLower().Contains(searchText))
            {
                string status = isAvailable[i] ? "Available" : "Checked Out";
                Console.WriteLine(titles[i] + " by " + authors[i] + " - " + status);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No matching book found");
    }

    static void CheckoutBook()
    {
        Console.Write("\nEnter book number to checkout: ");
        int bookNo = Convert.ToInt32(Console.ReadLine()) - 1;

        if (bookNo >= 0 && bookNo < titles.Length)
        {
            if (isAvailable[bookNo])
            {
                isAvailable[bookNo] = false;
                Console.WriteLine("Book checked out successfully");
            }
            else
            {
                Console.WriteLine("Book already checked out");
            }
        }
        else
        {
            Console.WriteLine("Invalid book number");
        }
    }
}
