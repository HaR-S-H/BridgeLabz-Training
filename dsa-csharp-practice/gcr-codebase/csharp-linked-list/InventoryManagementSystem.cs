class ItemNode
{
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int id, string name, int qty, double price)
    {
        ItemId = id;
        ItemName = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

class InventoryLinkedList
{
    private ItemNode head;

    // Add at Beginning
    public void AddAtBeginning(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);
        newNode.Next = head;
        head = newNode;
        Console.WriteLine("Item added at beginning.");
    }

    // Add at End
    public void AddAtEnd(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);

        if (head == null)
        {
            head = newNode;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
        Console.WriteLine("Item added at end.");
    }

    // Add at Specific Position (1-based index)
    public void AddAtPosition(int position, int id, string name, int qty, double price)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(id, name, qty, price);
            return;
        }

        ItemNode newNode = new ItemNode(id, name, qty, price);
        ItemNode temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
        Console.WriteLine("Item added at position " + position);
    }

    // Remove by Item ID
    public void RemoveById(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        if (head.ItemId == id)
        {
            head = head.Next;
            Console.WriteLine("Item removed.");
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != id)
            temp = temp.Next;

        if (temp.Next == null)
        {
            Console.WriteLine("Item not found.");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed.");
        }
    }

    // Update Quantity by Item ID
    public void UpdateQuantity(int id, int newQty)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                temp.Quantity = newQty;
                Console.WriteLine("Quantity updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Search by Item ID
    public void SearchById(int id)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                DisplayItem(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Search by Item Name
    public void SearchByName(string name)
    {
        ItemNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayItem(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Item not found.");
    }

    // Display All Items
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Console.WriteLine("\nInventory Items:");
        ItemNode temp = head;
        while (temp != null)
        {
            DisplayItem(temp);
            temp = temp.Next;
        }
    }

    // Calculate Total Inventory Value
    public void DisplayTotalValue()
    {
        double total = 0;
        ItemNode temp = head;

        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }

        Console.WriteLine("\nTotal Inventory Value = " + total);
    }

    // Sort by Item Name or Price (Bubble Sort)
    public void Sort(string criteria, bool ascending)
    {
        if (head == null || head.Next == null)
            return;

        bool swapped;
        do
        {
            swapped = false;
            ItemNode current = head;

            while (current.Next != null)
            {
                bool condition = false;

                if (criteria.ToLower() == "name")
                {
                    int result = string.Compare(current.ItemName, current.Next.ItemName, true);
                    condition = ascending ? result > 0 : result < 0;
                }
                else if (criteria.ToLower() == "price")
                {
                    condition = ascending
                        ? current.Price > current.Next.Price
                        : current.Price < current.Next.Price;
                }

                if (condition)
                {
                    SwapData(current, current.Next);
                    swapped = true;
                }

                current = current.Next;
            }

        } while (swapped);

        Console.WriteLine("Inventory sorted by " + criteria + " (" + (ascending ? "Ascending" : "Descending") + ").");
    }

    // Swap Node Data
    private void SwapData(ItemNode a, ItemNode b)
    {
        (a.ItemId, b.ItemId) = (b.ItemId, a.ItemId);
        (a.ItemName, b.ItemName) = (b.ItemName, a.ItemName);
        (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
        (a.Price, b.Price) = (b.Price, a.Price);
    }

    // Helper Method
    private void DisplayItem(ItemNode item)
    {
        Console.WriteLine($"ID: {item.ItemId}, Name: {item.ItemName}, Qty: {item.Quantity}, Price: {item.Price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventoryLinkedList inventory = new InventoryLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n==== Inventory Management System ====");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Item ID");
            Console.WriteLine("5. Update Quantity");
            Console.WriteLine("6. Search by Item ID");
            Console.WriteLine("7. Search by Item Name");
            Console.WriteLine("8. Display All Items");
            Console.WriteLine("9. Display Total Inventory Value");
            Console.WriteLine("10. Sort Inventory");
            Console.WriteLine("11. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int id, qty, position;
            string name, criteria;
            double price;
            bool ascending;

            switch (choice)
            {
                case 1:
                    ReadItem(out id, out name, out qty, out price);
                    inventory.AddAtBeginning(id, name, qty, price);
                    break;

                case 2:
                    ReadItem(out id, out name, out qty, out price);
                    inventory.AddAtEnd(id, name, qty, price);
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    position = Convert.ToInt32(Console.ReadLine());
                    ReadItem(out id, out name, out qty, out price);
                    inventory.AddAtPosition(position, id, name, qty, price);
                    break;

                case 4:
                    Console.Write("Enter Item ID to Remove: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    inventory.RemoveById(id);
                    break;

                case 5:
                    Console.Write("Enter Item ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Quantity: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    inventory.UpdateQuantity(id, qty);
                    break;

                case 6:
                    Console.Write("Enter Item ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    inventory.SearchById(id);
                    break;

                case 7:
                    Console.Write("Enter Item Name: ");
                    name = Console.ReadLine();
                    inventory.SearchByName(name);
                    break;

                case 8:
                    inventory.DisplayAll();
                    break;

                case 9:
                    inventory.DisplayTotalValue();
                    break;

                case 10:
                    Console.Write("Sort by (name/price): ");
                    criteria = Console.ReadLine();
                    Console.Write("Ascending? (true/false): ");
                    ascending = Convert.ToBoolean(Console.ReadLine());
                    inventory.Sort(criteria, ascending);
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

    static void ReadItem(out int id, out string name, out int qty, out double price)
    {
        Console.Write("Item ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Item Name: ");
        name = Console.ReadLine();
        Console.Write("Quantity: ");
        qty = Convert.ToInt32(Console.ReadLine());
        Console.Write("Price: ");
        price = Convert.ToDouble(Console.ReadLine());
    }
}
