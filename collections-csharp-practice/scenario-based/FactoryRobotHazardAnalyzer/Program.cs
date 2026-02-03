using System;
class Program
{
    public static double CalculateHazardRisk(double armPrecision, int workerDensity, string machineState)
    {
        if (armPrecision < 0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Arm Precision must be 0.0-1.0");
        }
        if (workerDensity < 1 ||workerDensity > 20)
        {
            throw new RobotSafetyException("Worker Density must be 1-20");
        }
        if (machineState != "Worn" && machineState != "Faulty" && machineState != "Critical")
        {
            throw new RobotSafetyException("Unsupported machine state");
        }
        double machineRiskFactor = 0;
        switch (machineState)
        {
            case "Worn":
                machineRiskFactor = 1.3;
                break;
            case "Faulty":
                machineRiskFactor = 2.0;
                break;
            case "Critical":
                machineRiskFactor = 3.0;
                break;
        }
        double HazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
        return HazardRisk;
    }
    static void Main()
    {
       try
       {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0)");
            double armPrecision = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Worker Density (1 - 20)");
            int workerDensity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical)");
            string machineState = Console.ReadLine();
            Console.WriteLine(CalculateHazardRisk(armPrecision, workerDensity, machineState));
        }
       catch (RobotSafetyException ex)
         {
            Console.WriteLine(ex.Message);
        }
    }
}