using System;
using System.Collections.Generic;

// Job Role
abstract class JobRole
{
    public abstract string RoleName { get; }
}

class SoftwareEngineer : JobRole
{
    public override string RoleName => "Software Engineer";
}

class DataScientist : JobRole
{
    public override string RoleName => "Data Scientist";
}

// Generic Resume
class Resume<T> where T : JobRole
{
    public string CandidateName { get; set; }
    public T Role { get; set; }

    public void Screen()
    {
        Console.WriteLine($"{CandidateName} screened for {Role.RoleName}");
    }
}

// Usage
class Program
{
    static void Main()
    {
        Resume<SoftwareEngineer> resume = new Resume<SoftwareEngineer>
        {
            CandidateName = "Harsh",
            Role = new SoftwareEngineer()
        };

        resume.Screen();
    }
}
