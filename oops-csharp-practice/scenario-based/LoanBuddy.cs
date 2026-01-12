using System;

// Interface for approval and EMI calculation
interface IApprovable
{
    bool ApproveLoan();       // Check eligibility
    double CalculateEMI();    // Calculate EMI
}

// Applicant class
class Applicant
{
    private string name;
    private int creditScore;
    private double income;
    private double loanAmount;

    // Constructor
    public Applicant(string name, int creditScore, double income, double loanAmount)
    {
        this.name = name;
        this.creditScore = creditScore;
        this.income = income;
        this.loanAmount = loanAmount;
    }

    // Getters
    public string Name { get { return name; } }
    protected int CreditScore { get { return creditScore; } }
    public double Income { get { return income; } }
    public double LoanAmount { get { return loanAmount; } }
}

// Base LoanApplication class
abstract class LoanApplication : IApprovable
{
    protected string loanType;
    protected int term; // in months
    protected double interestRate;
    protected Applicant applicant;
    protected bool approved;

    // Constructor
    public LoanApplication(Applicant applicant, string loanType, int term, double interestRate)
    {
        this.applicant = applicant;
        this.loanType = loanType;
        this.term = term;
        this.interestRate = interestRate;
        this.approved = false;
    }

    // Internal eligibility check
    protected bool CheckEligibility()
    {
        return applicant.CreditScore >= 650 && applicant.Income >= (applicant.LoanAmount / term) * 2;
    }

    // Accessor for loan status
    public bool IsApproved()
    {
        return approved;
    }

    public abstract bool ApproveLoan();
    public abstract double CalculateEMI();
}

// Personal Loan class
class PersonalLoan : LoanApplication
{
    public PersonalLoan(Applicant applicant, int term, double interestRate)
        : base(applicant, "Personal", term, interestRate) { }

    public override bool ApproveLoan()
    {
        if (CheckEligibility())
        {
            approved = true;
        }
        return approved;
    }

    public override double CalculateEMI()
    {
        if (!approved) return 0;
        double P = applicant.LoanAmount;
        double R = interestRate / 12 / 100;
        int N = term;
        double emi = (P * R * Math.Pow(1 + R, N)) / (Math.Pow(1 + R, N) - 1);
        return emi;
    }
}

// Home Loan class
class HomeLoan : LoanApplication
{
    public HomeLoan(Applicant applicant, int term, double interestRate)
        : base(applicant, "Home", term, interestRate) { }

    public override bool ApproveLoan()
    {
        if (CheckEligibility() && applicant.Income >= 50000) // stricter for home loans
        {
            approved = true;
        }
        return approved;
    }

    public override double CalculateEMI()
    {
        if (!approved) return 0;
        double P = applicant.LoanAmount;
        double R = interestRate / 12 / 100;
        int N = term;
        double emi = (P * R * Math.Pow(1 + R, N)) / (Math.Pow(1 + R, N) - 1);
        return emi * 0.95; // slightly discounted EMI for home loan
    }
}

// Auto Loan class
class AutoLoan : LoanApplication
{
    public AutoLoan(Applicant applicant, int term, double interestRate)
        : base(applicant, "Auto", term, interestRate) { }

    public override bool ApproveLoan()
    {
        if (CheckEligibility() && applicant.Income >= 30000)
        {
            approved = true;
        }
        return approved;
    }

    public override double CalculateEMI()
    {
        if (!approved) return 0;
        double P = applicant.LoanAmount;
        double R = interestRate / 12 / 100;
        int N = term;
        double emi = (P * R * Math.Pow(1 + R, N)) / (Math.Pow(1 + R, N) - 1);
        return emi * 1.02; // slightly higher EMI for auto loan
    }
}

// Test the LoanBuddy engine
class Program
{
    static void Main(string[] args)
    {
        Applicant a1 = new Applicant("Harsh Gupta", 700, 60000, 500000);
        Applicant a2 = new Applicant("Ravi Kumar", 620, 40000, 200000);

        LoanApplication personalLoan = new PersonalLoan(a1, 24, 12); // 24 months, 12% interest
        LoanApplication homeLoan = new HomeLoan(a1, 120, 8); // 10 years, 8%
        LoanApplication autoLoan = new AutoLoan(a2, 36, 10); // 3 years, 10%

        // Approve loans and calculate EMI
        Console.WriteLine("Personal Loan Approved? " + personalLoan.ApproveLoan());
        Console.WriteLine("Personal Loan EMI: " + personalLoan.CalculateEMI());

        Console.WriteLine("Home Loan Approved? " + homeLoan.ApproveLoan());
        Console.WriteLine("Home Loan EMI: " + homeLoan.CalculateEMI());

        Console.WriteLine("Auto Loan Approved? " + autoLoan.ApproveLoan());
        Console.WriteLine("Auto Loan EMI: " + autoLoan.CalculateEMI());
    }
}
