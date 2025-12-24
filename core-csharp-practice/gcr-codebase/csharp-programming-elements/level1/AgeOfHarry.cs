using System;

class AgeOfHarry
{
    static void Main()
    {       //define brith year and current year
        int birthYear = 2000;
        int currentYear = 2024;
            //calculate age
        int age = currentYear - birthYear;
        //print age
        Console.WriteLine($"Harry's age in {currentYear} is {age}");
    }
}
