using System;

class SmallestLargest
{
    public static int[] FindSmallestAndLargest(int n1, int n2, int n3)
    {
        int smallest = n1;
        int largest = n1;

        if (n2 < smallest) smallest = n2;
        if (n3 < smallest) smallest = n3;

        if (n2 > largest) largest = n2;
        if (n3 > largest) largest = n3;

        return new int[] { smallest, largest };
    }

    static void Main()
    {
        Console.Write("Enter 3 numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(a, b, c);
        Console.WriteLine("Smallest = " + result[0]);
        Console.WriteLine("Largest = " + result[1]);
    }
}
