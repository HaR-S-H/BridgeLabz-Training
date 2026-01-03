using System;

// Base class: Person
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Virtual method to display role (to be overridden)
    public virtual void DisplayRole()
    {
        Console.WriteLine($"Person: {Name}, Age: {Age}");
    }
}

// Subclass: Teacher
class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        this.Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}

// Subclass: Student
class Student : Person
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
        : base(name, age)
    {
        this.Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Grade: {Grade}");
    }
}

// Subclass: Staff
class Staff : Person
{
    public string Department { get; set; }

    public Staff(string name, int age, string department)
        : base(name, age)
    {
        this.Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Staff Name: {Name}, Age: {Age}, Department: {Department}");
    }
}

// Test program
class Program
{
    static void Main()
    {
        // Teacher
        Teacher t1 = new Teacher("Mr. Smith", 40, "Mathematics");
        t1.DisplayRole();
        Console.WriteLine();

        // Student
        Student s1 = new Student("Alice", 16, "10th Grade");
        s1.DisplayRole();
        Console.WriteLine();

        // Staff
        Staff st1 = new Staff("Mrs. Johnson", 35, "Administration");
        st1.DisplayRole();
    }
}
