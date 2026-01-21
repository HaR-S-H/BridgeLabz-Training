using System.Collections.Generic;

class RankUtility
{
    public static List<Student> MergeSort(List<Student> students)
    {
        if (students.Count <= 1)
            return students;

        int mid = students.Count / 2;

        List<Student> left = MergeSort(students.GetRange(0, mid));
        List<Student> right = MergeSort(students.GetRange(mid, students.Count - mid));

        return Merge(left, right);
    }

    private static List<Student> Merge(List<Student> left, List<Student> right)
    {
        List<Student> result = new List<Student>();
        int i = 0, j = 0;

        // Descending order by Marks (Rank List)
        while (i < left.Count && j < right.Count)
        {
            if (left[i].Marks >= right[j].Marks)
                result.Add(left[i++]);   // stable
            else
                result.Add(right[j++]);
        }

        while (i < left.Count)
            result.Add(left[i++]);

        while (j < right.Count)
            result.Add(right[j++]);

        return result;
    }
}
