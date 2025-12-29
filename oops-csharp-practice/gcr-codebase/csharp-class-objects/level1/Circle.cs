using System;
class Circle
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public void CalculateCircumferenceAndDisplay()
    {
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine("Circle Circumference :- " + circumference);

    }

}
class program
{
    static void Main()
    {
        Circle circle = new Circle(2);
        circle.CalculateCircumferenceAndDisplay();
        
    }
}