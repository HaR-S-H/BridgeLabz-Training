class PetrolPump
{
    public int Petrol, Distance;
    public PetrolPump(int p, int d)
    {
        Petrol = p;
        Distance = d;
    }
}

class CircularTour
{
    public static int FindStart(PetrolPump[] pumps)
    {
        int start = 0, surplus = 0, deficit = 0;

        for (int i = 0; i < pumps.Length; i++)
        {
            surplus += pumps[i].Petrol - pumps[i].Distance;

            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        return (surplus + deficit >= 0) ? start : -1;
    }
    static void Main()
    {
        PetrolPump[] pumps = { new PetrolPump(6, 4), new PetrolPump(3, 6), new PetrolPump(7, 3) };
        Console.WriteLine(FindStart(pumps));
        
    }
}
