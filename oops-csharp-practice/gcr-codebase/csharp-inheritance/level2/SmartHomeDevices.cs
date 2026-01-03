using System;

// Superclass: General device
class Device
{
    // Attributes common to all devices
    public int DeviceId { get; set; }
    public string Status { get; set; } // e.g., "On" or "Off"

    // Constructor to initialize Device
    public Device(int deviceId, string status)
    {
        this.DeviceId = deviceId;
        this.Status = status;
    }

    // Method to display general device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}

// Subclass: Thermostat (inherits from Device)
class Thermostat : Device
{
    // Additional attribute specific to Thermostat
    public double TemperatureSetting { get; set; }

    // Constructor for Thermostat
    public Thermostat(int deviceId, string status, double temperatureSetting)
        : base(deviceId, status) // Call superclass constructor
    {
        this.TemperatureSetting = temperatureSetting;
    }

    // Override DisplayStatus to include temperature
    public override void DisplayStatus()
    {
        base.DisplayStatus(); // Show general device info
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }
}

// Program to test
class Program
{
    static void Main()
    {
        // Create a generic device
        Device genericDevice = new Device(1, "On");
        genericDevice.DisplayStatus();

        Console.WriteLine();

        // Create a thermostat device
        Thermostat thermostat = new Thermostat(2, "On", 22.5);
        thermostat.DisplayStatus();
    }
}
