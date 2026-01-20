using System;
class Program
{

    public static bool CrackPassword(char[] password,int index,string current)
    {
        if(index==password.Length)
        {
           string attempt=current;
            if(attempt.Equals(new string(password)))
            {
                Console.WriteLine("Password Cracked: "+attempt);
                return true;
            }
            return false;
        }
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (CrackPassword(password, index + 1, current + c))
            {
                return true;
            }
        }
        return false;
    }
    static void Main()
    {
        string password = "hrsh";
        char[] arr=password.ToCharArray();
        CrackPassword(arr,0,"");

    }
}