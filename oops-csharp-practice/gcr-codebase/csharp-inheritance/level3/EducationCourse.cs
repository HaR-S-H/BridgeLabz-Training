using System;

// Base class: Course
class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; } // Duration in hours

    public Course(string courseName, int duration)
    {
        this.CourseName = courseName;
        this.Duration = duration;
    }

    // Virtual method to display course info
    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} hours");
    }
}

// Subclass: OnlineCourse (inherits from Course)
class OnlineCourse : Course
{
    public string Platform { get; set; } // e.g., Udemy, Coursera
    public bool IsRecorded { get; set; } // true if lectures are recorded

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        this.Platform = platform;
        this.IsRecorded = isRecorded;
    }

    // Override to include online course info
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Platform: {Platform}, Recorded: {IsRecorded}");
    }
}

// Subclass: PaidOnlineCourse (inherits from OnlineCourse)
class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; } // percentage discount

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        this.Fee = fee;
        this.Discount = discount;
    }

    // Override to include payment info
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        double discountedFee = Fee - (Fee * Discount / 100);
        Console.WriteLine($"Fee: ${Fee}, Discount: {Discount}%, Payable: ${discountedFee}");
    }
}

// Test program
class Program
{
    static void Main()
    {
        // Base course
        Course course1 = new Course("Mathematics", 40);
        course1.DisplayCourseInfo();
        Console.WriteLine();

        // Online course
        OnlineCourse course2 = new OnlineCourse("Physics", 30, "Coursera", true);
        course2.DisplayCourseInfo();
        Console.WriteLine();

        // Paid online course
        PaidOnlineCourse course3 = new PaidOnlineCourse("Programming in C#", 50, "Udemy", false, 200, 15);
        course3.DisplayCourseInfo();
    }
}
