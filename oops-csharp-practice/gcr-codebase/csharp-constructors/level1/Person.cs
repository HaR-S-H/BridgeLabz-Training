using System;
class Person
{   //instance fields 
    //attributes of person's class
    private  string name;
    private int age;
    private double height;
    private string nationality;
    //default constructor
    public Person()
    {
        this.name = "harsh";
        this.age = 21;
        this.height = 5.7;
        this.nationality = "indian";
    }
    //copy costructor which takes object as an argument and copy all the  values
    public Person(Person person)
    {
        this.name = person.name;
        this.age = person.age;
        this.height = person.height;
        this.nationality = person.nationality;
    }
    //showing details of person object
    public void DisplayDetails()
    {
        Console.WriteLine("Person Details :- ");
        Console.WriteLine("Name :- "+ name);
        Console.WriteLine("Age :- "+ age);
        Console.WriteLine("Height :- "+ height);
    }
}

class Program
{//entry point
    static void Main()
    {   //object creation
        Person person1 = new(); //calling default constructor
        Person person2 = new(person1);
        person1.DisplayDetails();
        person2.DisplayDetails();
    }
}