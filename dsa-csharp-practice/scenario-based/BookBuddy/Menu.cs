using System;
class Menu
{
    private IBookManager manager;
    public Menu(IBookManager manager)
    {
        this.manager = manager;
    }
    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n==== Book Manager ====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Sort Books Alphabetically");
            Console.WriteLine("3. Search By Author");
            Console.WriteLine("4. Export to Array");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    manager.AddBook(title, author);
                    break;
                case 2:
                    manager.SortBooksAlphabetically();
                    break;
                case 3:
                    Console.Write("Enter Author Name: ");
                    string searchAuthor = Console.ReadLine();
                    manager.SearchByAuthor(searchAuthor);
                    break;

                case 4:
                    string[] exported = manager.ExportToArray();
                    Console.WriteLine("\nExported Books:");
                    foreach (string book in exported)
                    {
                        Console.WriteLine(book);
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting Program...");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;


            }
        }
        while(choice!=5);
    }
}