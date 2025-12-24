using System;

class ChocolateDistribution
{
    static void Main()
    {   //take number of chocolates and children as input from user
        Console.Write("enter number of chocolates");

        int chocolates = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("enter number of children");
        int children = Convert.ToInt32(Console.ReadLine());
        //calculate chocolates per child and remaining chocolates
        int perChild = chocolates / children;

        int remaining = chocolates % children;
        //print the result
        Console.WriteLine($"The number of chocolates each child gets is {perChild} and the number of remaining chocolates is {remaining}");
    }
}
