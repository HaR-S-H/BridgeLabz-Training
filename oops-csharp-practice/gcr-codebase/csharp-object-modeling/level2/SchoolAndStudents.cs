using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
    public List<Student> Students = new List<Student>();

    public Course(string name)
    {
        CourseName = name;
    }

    public void ShowStudents()
    {
        Console.WriteLine("Students in " + CourseName);
        foreach (var s in Students)
            Console.WriteLine(s.Name);
    }
}

class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Enroll(Course course)
    {
        Courses.Add(course);
        course.Students.Add(this);
    }

    public void ViewCourses()
    {
        Console.WriteLine(Name + " enrolled courses:");
        foreach (var c in Courses)
            Console.WriteLine(c.CourseName);
    }
}

class School
{
    public string SchoolName;
    public List<Student> Students = new List<Student>();

    public School(string name)
    {
        SchoolName = name;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}
class Program
{
    static void Main()
    {
        School school = new School("ABC School");
        Student student1 = new Student("Harsh");
        Student student2 = new Student("Ravi");
        Course course1 = new Course("Maths");
        Course course2 = new Course("Science");
        student1.Enroll(course1);
        student1.Enroll(course2);
        student2.Enroll(course1);
        school.AddStudent(student1);
        school.AddStudent(student2);
        student1.ViewCourses();
        course1.ShowStudents();
    }
}