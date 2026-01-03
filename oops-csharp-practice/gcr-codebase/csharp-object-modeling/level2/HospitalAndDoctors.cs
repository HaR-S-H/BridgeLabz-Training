using System;
using System.Collections.Generic;

class Patient
{
    public string Name;

    public Patient(string name)
    {
        Name = name;
    }
}

class Doctor
{
    public string Name;

    public Doctor(string name)
    {
        Name = name;
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine($"Doctor {Name} is consulting patient {patient.Name}");
    }
}

class Hospital
{
    public List<Doctor> Doctors = new List<Doctor>();
    public List<Patient> Patients = new List<Patient>();
}

class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        hospital.Doctors.Add(new Doctor("Dr. Smith"));
        hospital.Doctors.Add(new Doctor("Dr. Johnson"));
        hospital.Patients.Add(new Patient("Alice"));
        hospital.Patients.Add(new Patient("Bob"));

        foreach (var patient in hospital.Patients)
        {
            foreach (var doctor in hospital.Doctors)
            {
                doctor.Consult(patient);
            }
        }
    }
}