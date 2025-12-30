using System;
class HotelBooking
{ //instace fields
    private string guestName;
    private string roomType;
    private int nights;
    
    public HotelBooking() //default constructors
    {
        this.guestName = "kushal";
        this.roomType = "couple";
        this.nights = 2;
    }
    public HotelBooking(string guestName, string roomType, int nights) //parameterized constructors
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }
    public HotelBooking(HotelBooking guestDetails) //copy constructors
    {
        this.guestName = guestDetails.guestName;
        this.roomType = guestDetails.roomType;
        this.nights = guestDetails.nights;
    }
    public void DisplayDetails() //showing details of a guest of an object
    {
        Console.WriteLine("GuestDetails :-");
        Console.WriteLine("Name :- " + guestName);
        Console.WriteLine("Room Type :-" + roomType);
        Console.WriteLine("Nights :- " + nights);
    }
}

class Program
{
    //entry point
    static void Main()
    {   //object creation
        HotelBooking booking1 = new HotelBooking();//calling default constructor
        HotelBooking booking2 = new HotelBooking("shivam", "couple", 6); //calling parameterized constructor
        HotelBooking booking3 = new HotelBooking(booking2); //calling copy constructor
        booking1.DisplayDetails(); //showing details by calling display detials method
        booking2.DisplayDetails();
        booking3.DisplayDetails();
    }
}