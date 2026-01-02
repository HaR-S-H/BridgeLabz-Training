using System;
class Student
{ //instace variables
    public int rollNumber;
    protected string name;
    private double cgpa;

    public Student(int rollNumber, string name, double cgpa) //parameterized constructor
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;
    }
    public void GetCgpa()
    {
        Console.WriteLine("Cgpa :- " + cgpa);
    }
    public void UpdateCgpa(double cgpa) //method for updating cgpa
    {
        this.cgpa = cgpa;
    }

}
class PostgraduateStudent : Student //inheritance
{
    public string specialization;
    public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization) : base(rollNumber, name, cgpa) //parameterized constructor
    {
        this.specialization = specialization;
    }
    public void DisplayDetails() //method to display details
    {
        Console.WriteLine("Postgraduate Student Details :- ");
        Console.WriteLine("Roll Number :- " + rollNumber);
        Console.WriteLine("Name :- " + name);
        GetCgpa();
        Console.WriteLine("Specialization :- " + specialization);
    }
}

class Program
{
    static void Main()
    {
        PostgraduateStudent student = new PostgraduateStudent(1, "harsh", 8.5, "CS"); //object creation
        student.DisplayDetails(); //calling method
        student.UpdateCgpa(9.0); //calling method
    }
}