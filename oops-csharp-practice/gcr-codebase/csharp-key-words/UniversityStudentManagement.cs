using System;

class Student
{
    public static string UniversityName = "ABC University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public char Grade;

    public Student(int rollNumber, string name, char grade)
    {
        this.RollNumber = rollNumber;
        this.Name = name;
        this.Grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void Display(object obj)
    {
        if (obj is Student)
        {
            Console.WriteLine($"Roll: {RollNumber}, Name: {Name}, Grade: {Grade}, University: {UniversityName}");
        }
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student(1, "Harsh", 'A');
        Student s2 = new Student(2, "Ravi", 'B');

        s1.Display(s1);
        Student.DisplayTotalStudents();
    }
}
