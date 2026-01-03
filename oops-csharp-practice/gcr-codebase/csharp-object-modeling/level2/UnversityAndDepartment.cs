using System;
using System.Collections.Generic;

class Faculty
{
    public string Name;

    public Faculty(string name)
    {
        Name = name;
    }
}

class Department
{
    public string DeptName;

    public Department(string name)
    {
        DeptName = name;
    }
}

class University
{
    public string UniversityName;
    public List<Department> Departments = new List<Department>();
    public List<Faculty> Faculties = new List<Faculty>();

    public University(string name)
    {
        UniversityName = name;
    }

    public void AddDepartment(string name)
    {
        Departments.Add(new Department(name));
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }
}

class Program
{
    static void Main()
    {
        University university = new University("ABC University");
        university.AddDepartment("IT");
        university.AddFaculty(new Faculty("Harsh"));
        university.AddFaculty(new Faculty("Ravi"));
    }
}