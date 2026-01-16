using System;
class Vehicle
{
    public string Number { get; private set; }
    public Vehicle Next { get; set; }

    public Vehicle(string number)
    {
        Number = number;
        Next = null;
    }

    public override string ToString()
    {
        return Number.ToString();
    }
}
