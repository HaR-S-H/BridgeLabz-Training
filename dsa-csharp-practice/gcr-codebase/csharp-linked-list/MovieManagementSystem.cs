class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public MovieNode Next;
    public MovieNode Prev;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

class MovieDoublyLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    // Add at Beginning
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

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

        Console.WriteLine("Movie added at beginning.");
    }

    // Add at End
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

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

        Console.WriteLine("Movie added at end.");
    }

    // Add at Specific Position (1-based index)
    public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode newNode = new MovieNode(title, director, year, rating);
        MovieNode temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null || temp.Next == null)
        {
            AddAtEnd(title, director, year, rating);
            return;
        }

        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;

        Console.WriteLine("Movie added at position " + position);
    }

    // Remove by Movie Title
    public void RemoveByTitle(string title)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        MovieNode temp = head;

        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        // If first node
        if (temp == head)
        {
            head = head.Next;
            if (head != null)
                head.Prev = null;
            else
                tail = null;
        }
        // If last node
        else if (temp == tail)
        {
            tail = tail.Prev;
            tail.Next = null;
        }
        // If middle node
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }

        Console.WriteLine("Movie removed successfully.");
    }

    // Search by Director
    public void SearchByDirector(string director)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found for this director.");
    }

    // Search by Rating
    public void SearchByRating(double rating)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found with this rating.");
    }

    // Update Rating by Title
    public void UpdateRating(string title, double newRating)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found.");
    }

    // Display Forward
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movies to display.");
            return;
        }

        Console.WriteLine("\nMovies (Forward):");
        MovieNode temp = head;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Next;
        }
    }

    // Display Reverse
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No movies to display.");
            return;
        }

        Console.WriteLine("\nMovies (Reverse):");
        MovieNode temp = tail;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Prev;
        }
    }

    // Helper Method
    private void DisplayMovie(MovieNode movie)
    {
        Console.WriteLine($"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MovieDoublyLinkedList list = new MovieDoublyLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n==== Movie Management System ====");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Title");
            Console.WriteLine("5. Search by Director");
            Console.WriteLine("6. Search by Rating");
            Console.WriteLine("7. Update Rating");
            Console.WriteLine("8. Display Forward");
            Console.WriteLine("9. Display Reverse");
            Console.WriteLine("10. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            string title, director;
            int year, position;
            double rating;

            switch (choice)
            {
                case 1:
                    ReadMovie(out title, out director, out year, out rating);
                    list.AddAtBeginning(title, director, year, rating);
                    break;

                case 2:
                    ReadMovie(out title, out director, out year, out rating);
                    list.AddAtEnd(title, director, year, rating);
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    position = Convert.ToInt32(Console.ReadLine());
                    ReadMovie(out title, out director, out year, out rating);
                    list.AddAtPosition(position, title, director, year, rating);
                    break;

                case 4:
                    Console.Write("Enter Movie Title to Remove: ");
                    title = Console.ReadLine();
                    list.RemoveByTitle(title);
                    break;

                case 5:
                    Console.Write("Enter Director Name: ");
                    director = Console.ReadLine();
                    list.SearchByDirector(director);
                    break;

                case 6:
                    Console.Write("Enter Rating: ");
                    rating = Convert.ToDouble(Console.ReadLine());
                    list.SearchByRating(rating);
                    break;

                case 7:
                    Console.Write("Enter Movie Title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter New Rating: ");
                    rating = Convert.ToDouble(Console.ReadLine());
                    list.UpdateRating(title, rating);
                    break;

                case 8:
                    list.DisplayForward();
                    break;

                case 9:
                    list.DisplayReverse();
                    break;

                case 10:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 10);
    }

    static void ReadMovie(out string title, out string director, out int year, out double rating)
    {
        Console.Write("Title: ");
        title = Console.ReadLine();
        Console.Write("Director: ");
        director = Console.ReadLine();
        Console.Write("Year: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Rating: ");
        rating = Convert.ToDouble(Console.ReadLine());
    }
}
