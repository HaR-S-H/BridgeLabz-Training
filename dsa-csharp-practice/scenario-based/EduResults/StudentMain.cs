using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // District-wise sorted lists
        List<Student> district1 = new List<Student>
        {
            new Student(101, "Amit", 95),
            new Student(102, "Riya", 88),
            new Student(103, "Karan", 80)
        };

        List<Student> district2 = new List<Student>
        {
            new Student(201, "Neha", 96),
            new Student(202, "Rahul", 88),
            new Student(203, "Pooja", 82)
        };

        // Merge all district lists
        List<Student> stateList = new List<Student>();
        stateList.AddRange(district1);
        stateList.AddRange(district2);

        // Apply Merge Sort
        List<Student> rankList = RankUtility.MergeSort(stateList);

        Console.WriteLine("STATE WISE RANK LIST\n");
        int rank = 1;
        foreach (var student in rankList)
        {
            Console.WriteLine($"Rank {rank++}: {student}");
        }
    }
}
