class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, string seat)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

class TicketReservationSystem
{
    private TicketNode head;

    // Add new ticket at end
    public void AddTicket(int id, string customer, string movie, string seat)
    {
        TicketNode newNode = new TicketNode(id, customer, movie, seat);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            Console.WriteLine("Ticket booked successfully.");
            return;
        }

        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;

        Console.WriteLine("Ticket booked successfully.");
    }

    // Remove ticket by Ticket ID
    public void RemoveTicket(int id)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets to remove.");
            return;
        }

        TicketNode curr = head;
        TicketNode prev = null;

        // Case: Only one node
        if (head.TicketId == id && head.Next == head)
        {
            head = null;
            Console.WriteLine("Ticket removed.");
            return;
        }

        // Case: Head node
        if (head.TicketId == id)
        {
            TicketNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = head.Next;
            head = head.Next;
            Console.WriteLine("Ticket removed.");
            return;
        }

        // Traverse list
        do
        {
            prev = curr;
            curr = curr.Next;

            if (curr.TicketId == id)
            {
                prev.Next = curr.Next;
                Console.WriteLine("Ticket removed.");
                return;
            }

        } while (curr != head);

        Console.WriteLine("Ticket not found.");
    }

    // Display all tickets
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Console.WriteLine("\n--- Booked Tickets ---");
        TicketNode temp = head;

        do
        {
            DisplayTicket(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Search by Customer Name
    public void SearchByCustomer(string name)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        bool found = false;
        TicketNode temp = head;

        do
        {
            if (temp.CustomerName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayTicket(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No ticket found for this customer.");
    }

    // Search by Movie Name
    public void SearchByMovie(string movie)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        bool found = false;
        TicketNode temp = head;

        do
        {
            if (temp.MovieName.Equals(movie, StringComparison.OrdinalIgnoreCase))
            {
                DisplayTicket(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No ticket found for this movie.");
    }

    // Count total tickets
    public int CountTickets()
    {
        if (head == null)
            return 0;

        int count = 0;
        TicketNode temp = head;

        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        return count;
    }

    // Helper Method
    private void DisplayTicket(TicketNode ticket)
    {
        Console.WriteLine($"Ticket ID: {ticket.TicketId}");
        Console.WriteLine($"Customer: {ticket.CustomerName}");
        Console.WriteLine($"Movie: {ticket.MovieName}");
        Console.WriteLine($"Seat: {ticket.SeatNumber}");
        Console.WriteLine($"Time: {ticket.BookingTime}");
        Console.WriteLine("----------------------------");
    }
}


class Program
{
    static void Main(string[] args)
    {
        TicketReservationSystem system = new TicketReservationSystem();
        int choice;

        do
        {
            Console.WriteLine("\n==== Online Ticket Reservation ====");
            Console.WriteLine("1. Book Ticket");
            Console.WriteLine("2. Remove Ticket");
            Console.WriteLine("3. Display All Tickets");
            Console.WriteLine("4. Search by Customer Name");
            Console.WriteLine("5. Search by Movie Name");
            Console.WriteLine("6. Count Total Tickets");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int id;
            string customer, movie, seat;

            switch (choice)
            {
                case 1:
                    Console.Write("Ticket ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Customer Name: ");
                    customer = Console.ReadLine();
                    Console.Write("Movie Name: ");
                    movie = Console.ReadLine();
                    Console.Write("Seat Number: ");
                    seat = Console.ReadLine();
                    system.AddTicket(id, customer, movie, seat);
                    break;

                case 2:
                    Console.Write("Enter Ticket ID to remove: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    system.RemoveTicket(id);
                    break;

                case 3:
                    system.DisplayTickets();
                    break;

                case 4:
                    Console.Write("Enter Customer Name: ");
                    customer = Console.ReadLine();
                    system.SearchByCustomer(customer);
                    break;

                case 5:
                    Console.Write("Enter Movie Name: ");
                    movie = Console.ReadLine();
                    system.SearchByMovie(movie);
                    break;

                case 6:
                    Console.WriteLine($"Total Tickets Booked: {system.CountTickets()}");
                    break;

                case 7:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 7);
    }
}
