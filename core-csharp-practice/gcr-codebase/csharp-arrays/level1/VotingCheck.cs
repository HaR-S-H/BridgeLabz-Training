using System;

class VotingCheck
{
    static void Main()
    {   //  declare an array to hold ages of 10 students
        int[] ages = new int[10];
        // take ages as input from user
        for (int i = 0; i < ages.Length; i++)
        {
            Console.WriteLine("enter age of student" + (i + 1));
            ages[i] = int.Parse(Console.ReadLine());
        }
        // check voting eligibility for each age
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                Console.WriteLine("Invalid age");
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine("The student with the age " + ages[i] + " can vote");
            }
            else
            {
                Console.WriteLine("The student with the age " + ages[i] + " cannot vote");
            }
        }
    }
}
