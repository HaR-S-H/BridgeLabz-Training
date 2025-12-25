using System;

class OTPGenerator
{
    static void Main()
    {
        int[] otp = new int[10];
        for (int i = 0; i < 10; i++)
            otp[i] = GenerateOTP();

        Console.WriteLine("Unique OTPs: " + AreUnique(otp));
    }

    static int GenerateOTP()
    {
        Random r = new Random();
        return r.Next(100000, 999999);
    }

    static bool AreUnique(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            for (int j = i + 1; j < a.Length; j++)
                if (a[i] == a[j]) return false;
        return true;
    }
}
