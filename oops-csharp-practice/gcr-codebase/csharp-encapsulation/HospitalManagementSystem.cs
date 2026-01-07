using System;
public interface IMedicalRecord
{
    void AddRecord(string diagnosis, string history);
    void ViewRecords();
}



public abstract class Patient : IMedicalRecord
{
    // Encapsulation: private fields
    private int patientId;
    private string name;
    private int age;

    // Sensitive data (protected)
    protected string diagnosis;
    protected string medicalHistory;

    public Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    // Abstract method
    public abstract double CalculateBill();

    // Concrete method
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    // Interface methods
    public void AddRecord(string diagnosis, string history)
    {
        this.diagnosis = diagnosis;
        this.medicalHistory = history;
        Console.WriteLine("Medical record added successfully.");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis: " + diagnosis);
        Console.WriteLine("Medical History: " + medicalHistory);
    }
}
public class InPatient : Patient
{
    private int numberOfDays;
    private double dailyCharge;

    public InPatient(int id, string name, int age, int days, double charge)
        : base(id, name, age)
    {
        numberOfDays = days;
        dailyCharge = charge;
    }

    public override double CalculateBill()
    {
        double total = numberOfDays * dailyCharge;
        return total;
    }
}
public class OutPatient : Patient
{
    private double consultationFee;
    private double testCharge;

    public OutPatient(int id, string name, int age, double consultationFee, double testCharge)
        : base(id, name, age)
    {
        this.consultationFee = consultationFee;
        this.testCharge = testCharge;
    }

    public override double CalculateBill()
    {
        double total = consultationFee + testCharge;
        return total;
    }
}


class Program
{
    static void Main()
    {
        // Polymorphism: base class reference
        Patient patient1 = new InPatient(101, "Rahul", 45, 5, 2000);
        Patient patient2 = new OutPatient(102, "Anita", 30, 500, 300);

        Console.WriteLine("---- In Patient ----");
        patient1.GetPatientDetails();
        patient1.AddRecord("Pneumonia", "Admitted for respiratory treatment");
        patient1.ViewRecords();
        Console.WriteLine("Total Bill: " + patient1.CalculateBill());

        Console.WriteLine();

        Console.WriteLine("---- Out Patient ----");
        patient2.GetPatientDetails();
        patient2.AddRecord("Fever", "Visited for general checkup");
        patient2.ViewRecords();
        Console.WriteLine("Total Bill: " + patient2.CalculateBill());
    }
}
