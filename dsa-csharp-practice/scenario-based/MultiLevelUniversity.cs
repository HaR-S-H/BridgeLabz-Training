using System;
using System.Collections.Generic;

// Course type
abstract class CourseType
{
    public abstract string EvaluationMethod { get; }
}

class ExamCourse : CourseType
{
    public override string EvaluationMethod => "Written Exam";
}

class AssignmentCourse : CourseType
{
    public override string EvaluationMethod => "Assignments";
}

// Generic Course
class Course<T> where T : CourseType
{
    public string CourseName { get; set; }
    public T CourseEvaluation { get; set; }

    public void Display()
    {
        Console.WriteLine($"{CourseName} - {CourseEvaluation.EvaluationMethod}");
    }
}

// Usage
class Program
{
    static void Main()
    {
        Course<ExamCourse> math = new Course<ExamCourse>
        {
            CourseName = "Mathematics",
            CourseEvaluation = new ExamCourse()
        };

        math.Display();
    }
}
