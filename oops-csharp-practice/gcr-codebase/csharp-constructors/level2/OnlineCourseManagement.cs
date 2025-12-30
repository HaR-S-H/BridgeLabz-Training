using System; //importing classes
class Course
{   //instance variables
    private string courseName;
    private string duration;
    private double fee;
    //class variable
    private static string instituteName = "GLA university"; //static because it is common for all courses
    public Course(string courseName, string duration, double fee)
    { // parameterized constructor whenever new course is added it runs
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }
    public void DisplayCourseDetails() //method to show course details 
    {
        Console.WriteLine("Course Details :- ");
        Console.WriteLine("CourseName :- " + courseName);
        Console.WriteLine("Duration :-" + duration);
        Console.WriteLine("Fee :- " + fee);
    }
    public static void UpdateInstituteName(string newInstituteName) //static method because it is common for all the courses  and it is updating static field instituteName
    {
        instituteName = newInstituteName;
    }
}

class Program
{ //entry point
    static void Main()
    { //course object creation
        Course course = new Course("B tech Hons.", "4 years", 250000); //calling parameterized constructor 
        course.DisplayCourseDetails(); //showing course details
        Course.UpdateInstituteName("GL bajaj"); //calling method for updating institute name
    }
}