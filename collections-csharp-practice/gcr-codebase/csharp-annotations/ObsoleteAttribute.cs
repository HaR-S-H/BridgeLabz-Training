using System;

class LegacyAPI
{
    [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Running old feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("Running new feature");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();  // Shows warning
        api.NewFeature();
    }
}
