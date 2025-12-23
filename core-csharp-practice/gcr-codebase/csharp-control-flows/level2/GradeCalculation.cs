using System;
class GradeCalculation
{
    static void Main()
    {
        Console.Write("Enter Physics marks: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter Chemistry marks: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter Maths marks: ");
        int m = int.Parse(Console.ReadLine());

        double avg = (p + c + m) / 3.0;
        string grd = "";
        string remark = "";

        if (avg >= 90)
        {
            grd = "A+";
            remark = "Excellent";
        }
        else if (avg >= 75)
        {
            grd = "A";
            remark = "Very Good";
        }
        else if (avg >= 60)
        {
            grd = "B";
            remark = "Good";
        }
        else if (avg >= 50)
        {
            grd = "C";
            remark = "Average";
        }
        else
        {
            grd = "F";
            remark = "Fail";
        }

        Console.WriteLine("Average: " + avg);
        Console.WriteLine("Grade: " + grd);
        Console.WriteLine("Remarks: " + remark);
    }
}