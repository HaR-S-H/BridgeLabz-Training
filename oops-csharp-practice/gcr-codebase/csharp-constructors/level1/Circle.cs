using System;
class Circle
{   //instance variable
    private double radius;
    //default construcr
    public Circle() : this(2.0) //construcr chaining using this keyword it call to parameterized constructor 
    {

    }
    //parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }
    //showing details of an object
    public void DisplayDetails()
    {
        Console.WriteLine("Radius :- " + radius);
    }
}

class Program
{
    //entry point
    static void Main()
    {   //object creation
        Circle circle = new Circle(); //calling default constructor
        circle.DisplayDetails(); //showing radius

    }
}

