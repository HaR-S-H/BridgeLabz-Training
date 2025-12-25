using System;

class StudentVote
{
    static void Main()
    {
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote");
        }
    }

    static bool CanStudentVote(int age)
    {
        if (age < 0)
            return false;
        return age >= 18;
    }
}
