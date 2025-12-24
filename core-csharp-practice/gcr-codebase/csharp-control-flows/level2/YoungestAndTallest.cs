using System;
class YoungestAndTallest
{
    static void Main()
    {   // take ages and heights of Amar, Akbar and Anthony as input from user
        Console.Write("enter Amar age");
        int aAge = int.Parse(Console.ReadLine());
        Console.Write("enter Akbar age");
        int kAge = int.Parse(Console.ReadLine());
        Console.Write("enter Anthony age");
        int tAge = int.Parse(Console.ReadLine());

        Console.Write("enter Amar height");
        double aHt = double.Parse(Console.ReadLine());
        Console.Write("enter Akbar height");
        double kHt = double.Parse(Console.ReadLine());
        Console.Write("enter Anthony height");
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
