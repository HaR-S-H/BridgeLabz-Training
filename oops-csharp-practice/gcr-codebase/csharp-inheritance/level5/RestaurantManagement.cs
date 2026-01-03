using System;

// Base class: Person
class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        this.Name = name;
        this.Id = id;
    }

    // Display basic info
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}

// Interface: Worker
interface IWorker
{
    void PerformDuties();
}

// Subclass: Chef inherits Person and implements IWorker
class Chef : Person, IWorker
{
    public string Specialty { get; set; }

    public Chef(string name, int id, string specialty)
        : base(name, id)
    {
        this.Specialty = specialty;
    }

    // Implementation of PerformDuties
    public void PerformDuties()
    {
        Console.WriteLine($"Chef {Name} is preparing dishes. Specialty: {Specialty}");
    }
}

// Subclass: Waiter inherits Person and implements IWorker
class Waiter : Person, IWorker
{
    public int TableNumber { get; set; }

    public Waiter(string name, int id, int tableNumber)
        : base(name, id)
    {
        this.TableNumber = tableNumber;
    }

    // Implementation of PerformDuties
    public void PerformDuties()
    {
        Console.WriteLine($"Waiter {Name} is serving Table {TableNumber}");
    }
}

// Test program
class Program
{
    static void Main()
    {
        // Create Chef object
        Chef chef1 = new Chef("Gordon Ramsay", 101, "Italian Cuisine");
        chef1.DisplayInfo();
        chef1.PerformDuties();
        Console.WriteLine();

        // Create Waiter object
        Waiter waiter1 = new Waiter("Alice", 102, 5);
        waiter1.DisplayInfo();
        waiter1.PerformDuties();
    }
}
