using System;

class VolumeOfEarth
{
    static void Main()
    {   //radius of earth in kilometers
        double radius = 6378;
        double pi = Math.PI;

        double volumeKm = (4.0 / 3.0) * pi * Math.Pow(radius, 3);
        double volumeMiles = volumeKm / Math.Pow(1.6, 3);

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}");
    }
}
