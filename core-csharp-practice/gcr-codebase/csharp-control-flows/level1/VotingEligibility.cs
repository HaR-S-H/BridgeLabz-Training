using System;

class VotingEligibility
{
    static void Main()
    {   // take age as input from user
        Console.Write("enter age");
        int age = int.Parse(Console.ReadLine());
        // check voting eligibility
        if (age >= 18)
            Console.WriteLine($"the person's age is {age} and can vote.");
        else
            Console.WriteLine($"the person's age is {age} and cannot vote.");
    }
}
