using System;
class SimpleInterest
{
    static void Main()
    {
        double principal = 1000.0;
        double rate = 5.0;
        double time = 3.0;
        double simpleInterest = (principal * rate * time) / 100;
        Console.Write(simpleInterest);
    }
}