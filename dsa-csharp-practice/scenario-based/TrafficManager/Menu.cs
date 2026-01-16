using System;

class Program
{
    static void Main()
    {
        CircularLinkedList roundabout = new CircularLinkedList();
        VehicleQueue queue = new VehicleQueue(5);

        while (true)
        {
            Console.WriteLine("\n--- Traffic Manager ---");
            Console.WriteLine("1. Add vehicle to queue");
            Console.WriteLine("2. Move vehicle to roundabout");
            Console.WriteLine("3. Remove vehicle from roundabout");
            Console.WriteLine("4. Display roundabout");
            Console.WriteLine("5. Display queue");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter vehicle number: ");
                    queue.Enqueue(Console.ReadLine());
                    break;

                case 2:
                    string v = queue.Dequeue();
                    if (v != null)
                        roundabout.AddVehicle(v);
                    break;

                case 3:
                    Console.Write("Enter vehicle number to remove: ");
                    roundabout.RemoveVehicle(Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine(roundabout);
                    break;

                case 5:
                    Console.WriteLine(queue);
                    break;

                case 6:
                    return;
            }
        }
    }
}
