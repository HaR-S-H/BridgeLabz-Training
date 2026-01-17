using System;
using System.Collections.Generic;
class User
{
    public string Name { get; private set; }
    public int Steps { get; set; }
    public User(string Name)
    {
        this.Name = Name;
        Steps = 0;
    }
    
    public override string ToString()
    {
        return "User: " + Name + ", Steps: " + Steps;
    }
}
class BubbleUtility
{
    public static void BubbleSort(List<User> users)
    {
        int n = users.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                    if(users[j].Steps>users[j+1].Steps)
                    {
                        Swap(users, j, j + 1);
                    }
            }
        }
    }
    public static void Swap(List<User> users, int i, int j)
    {
        User temp = users[i];
        users[i] = users[j];
        users[j] = temp;
    }
}
class Program
{
    static void Main()
    {
        List<User> users = new List<User>()
        {
            new User("Alice") { Steps = 12000 },
            new User("Bob") { Steps = 8000 },
            new User("Charlie") { Steps = 15000 },
            new User("Diana") { Steps = 5000 },
            new User("Eve") { Steps = 20000 }

        };
        Console.WriteLine("Before Sorting:");
        foreach (User u in users)
        {
            Console.WriteLine(u.ToString());
        }
        BubbleUtility.BubbleSort(users);
        Console.WriteLine("\nAfter Sorting by Steps (Ascending):");
        foreach (User u in users)
        {
            Console.WriteLine(u.ToString());
        }
    }
}
