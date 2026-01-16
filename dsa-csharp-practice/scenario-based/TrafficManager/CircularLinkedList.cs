class CircularLinkedList : IRoundabout
{
    private Vehicle head;

    public void AddVehicle(string number)
    {
        Vehicle newCar = new Vehicle(number);

        if (head == null)
        {
            head = newCar;
            newCar.Next = head;
        }
        else
        {
            Vehicle temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newCar;
            newCar.Next = head;
        }
    }

    public void RemoveVehicle(string number)
    {
        if (head == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        Vehicle current = head;
        Vehicle prev = null;

        do
        {
            if (current.Number == number)
            {
                if (current == head)
                {
                    if (head.Next == head)
                        head = null;
                    else
                    {
                        Vehicle last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }
                }
                else
                {
                    prev.Next = current.Next;
                }

                Console.WriteLine($"Vehicle {number} removed.");
                return;
            }

            prev = current;
            current = current.Next;

        } while (current != head);

        Console.WriteLine("Vehicle not found.");
    }

    public override string ToString()
    {
        if (head == null)
            return "Roundabout is empty.";

        string result = "Roundabout: ";
        Vehicle temp = head;

        do
        {
            result += temp + " -> ";
            temp = temp.Next;
        } while (temp != head);

        return result + "(back to start)";
    }
}
