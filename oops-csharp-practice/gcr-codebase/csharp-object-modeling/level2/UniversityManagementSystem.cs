using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
    public Professor Professor;

    public Course(string name)
    {
        CourseName = name;
    }

    public void AssignProfessor(Professor professor)
    {
        Professor = professor;
        Console.WriteLine(professor.Name + " assigned to " + CourseName);
    }
}

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }

    public void EnrollCourse(Course course)
    {
        Console.WriteLine(Name + " enrolled in " + course.CourseName);
    }
}

class Professor
{
    public string Name;

    public Professor(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Professor professor = new Professor("Dr. Smith");
        Course course = new Course("Computer Science");
        course.AssignProfessor(professor);
        Student student = new Student("John Doe");
        student.EnrollCourse(course);
    }
}