using System;

public interface IControllable
{
    void TurnOn();
    void TurnOff();
}
public class Appliance
{
    private string name;
    public Appliance(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

}

public class Light : Appliance,IControllable
{
    public Light(string name) : base(name)
    {

    }
    public void TurnOn()
    {
        Console.WriteLine("Light turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("Light turned off");
    }

}

public class Fan : Appliance, IControllable
{
    public Fan(string name) : base(name)
    { }
    public void TurnOn()
    {
        Console.WriteLine("Fan turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("Fan turned off");
    }
}
public class Ac : Appliance, IControllable
{
    public Ac(string name) : base(name)
    { }
    public void TurnOn()
    {
        Console.WriteLine("AC turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("AC turned off");
    }
}

class Program
{
   static void Main()
    {
        Appliance light = new Light("CFL");
        Appliance fan = new Fan("Philips");
        Appliance ac = new Ac("Panasonic");
        (light as IControllable).TurnOn();
        (light as IControllable).TurnOff();
        (fan as IControllable).TurnOn();
        (fan as IControllable).TurnOff();
        (ac as IControllable).TurnOn();
        (ac as IControllable).TurnOff();
    }
    
}