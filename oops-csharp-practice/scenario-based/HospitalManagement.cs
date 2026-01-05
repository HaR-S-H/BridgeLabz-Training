using System;
public interface IPayable
{
    double CalculateBill();
}

public class Bill
{
    public static void PrintBill(IPayable payable)
    {
        Console.WriteLine("Total Bill Amount: "+payable.CalculateBill());
    }
}
public class InPatient : Patient, IPayable
{
    public int NumberOfDays { get; set; }
    public double DailyCharge { get; set; }

    public double CalculateBill()
    {
        return NumberOfDays * DailyCharge;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("InPatient: " + Name +", Age: "+Age+", Days: "+NumberOfDays);
    }
}
public class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
}

public abstract class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void DisplayInfo();
}
public class OutPatient : Patient, IPayable
{
    public double ConsultationFee { get; set; }

    public double CalculateBill()
    {
        return ConsultationFee;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("OutPatient: "+Name+", Age: "+Age);
    }
}

class Program
{
    static void Main()
    {
        Patient p1 = new InPatient
        {
            PatientId = 1,
            Name = "Rahul",
            Age = 30,
            NumberOfDays = 5,
            DailyCharge = 2000
        };

        Patient p2 = new OutPatient
        {
            PatientId = 2,
            Name = "Anita",
            Age = 25,
            ConsultationFee = 500
        };

        p1.DisplayInfo();
        Bill.PrintBill((IPayable)p1);

        p2.DisplayInfo();
        Bill.PrintBill((IPayable)p2);
    }
}
