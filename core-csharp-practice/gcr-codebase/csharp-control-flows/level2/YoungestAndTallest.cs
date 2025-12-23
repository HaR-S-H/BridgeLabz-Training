using System;
class YoungestAndTallest
{
    static void Main()
    {
        Console.Write("Enter Amar age: ");
        int aAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar age: ");
        int kAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony age: ");
        int tAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Amar height: ");
        double aHt = double.Parse(Console.ReadLine());
        Console.Write("Enter Akbar height: ");
        double kHt = double.Parse(Console.ReadLine());
        Console.Write("Enter Anthony height: ");
        double tHt = double.Parse(Console.ReadLine());

        int minAge = aAge;
        string youngest = "Amar";
        if (kAge < minAge) { minAge = kAge; youngest = "Akbar"; }
        if (tAge < minAge) { minAge = tAge; youngest = "Anthony"; }

        double maxHt = aHt;
        string tallest = "Amar";
        if (kHt > maxHt) { maxHt = kHt; tallest = "Akbar"; }
        if (tHt > maxHt) { maxHt = tHt; tallest = "Anthony"; }

        Console.WriteLine("Youngest: " + youngest);
        Console.WriteLine("Tallest: " + tallest);
    }
}
