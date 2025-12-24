using System;

class SimpleInterest
{
    static void Main()
    {// take Principal, Rate of Interest and Time as input from user
        Console.Write("enter prencipal");

        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter Rete of Interest");
        double rate = Convert.ToDouble(Console.ReadLine());
        //Time
        Console.Write("enter Time");

        double time = Convert.ToDouble(Console.ReadLine());
        // calculate Simple Interest
        double sipleInterest = (principal * rate * time) / 100;
    // print the result
        Console.WriteLine($"The Simple Interest is {sipleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
