using System;
using System.Collections.Generic;

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;
    public List<int> Friends;   // List of Friend IDs
    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Friends = new List<int>();
        Next = null;
    }
}
class SocialNetwork
{
    private UserNode head;

    // Add New User
    public void AddUser(int id, string name, int age)
    {
        UserNode newNode = new UserNode(id, name, age);

        if (head == null)
        {
            head = newNode;
            return;
        }

        UserNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
        Console.WriteLine("User added successfully.");
    }

    // Search User by ID
    public UserNode SearchById(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    // Search User by Name
    public void SearchByName(string name)
    {
        UserNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayUser(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("User not found.");
    }

    // Add Friend Connection (Bidirectional)
    public void AddFriendConnection(int id1, int id2)
    {
        UserNode user1 = SearchById(id1);
        UserNode user2 = SearchById(id2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.Friends.Contains(id2))
            user1.Friends.Add(id2);

        if (!user2.Friends.Contains(id1))
            user2.Friends.Add(id1);

        Console.WriteLine("Friend connection added.");
    }

    // Remove Friend Connection
    public void RemoveFriendConnection(int id1, int id2)
    {
        UserNode user1 = SearchById(id1);
        UserNode user2 = SearchById(id2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        user1.Friends.Remove(id2);
        user2.Friends.Remove(id1);

        Console.WriteLine("Friend connection removed.");
    }

    // Display All Friends of a User
    public void DisplayFriends(int id)
    {
        UserNode user = SearchById(id);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine($"\nFriends of {user.Name}:");
        if (user.Friends.Count == 0)
        {
            Console.WriteLine("No friends.");
            return;
        }

        foreach (int friendId in user.Friends)
        {
            UserNode friend = SearchById(friendId);
            if (friend != null)
                Console.WriteLine($"ID: {friend.UserId}, Name: {friend.Name}");
        }
    }

    // Find Mutual Friends
    public void FindMutualFriends(int id1, int id2)
    {
        UserNode user1 = SearchById(id1);
        UserNode user2 = SearchById(id2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        Console.WriteLine($"\nMutual Friends of {user1.Name} and {user2.Name}:");
        bool found = false;

        foreach (int f1 in user1.Friends)
        {
            if (user2.Friends.Contains(f1))
            {
                UserNode mutual = SearchById(f1);
                if (mutual != null)
                {
                    Console.WriteLine($"ID: {mutual.UserId}, Name: {mutual.Name}");
                    found = true;
                }
            }
        }

        if (!found)
            Console.WriteLine("No mutual friends.");
    }

    // Count Friends for Each User
    public void CountFriends()
    {
        UserNode temp = head;

        Console.WriteLine("\nFriend Count:");
        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} has {temp.Friends.Count} friends.");
            temp = temp.Next;
        }
    }

    // Display All Users
    public void DisplayAllUsers()
    {
        if (head == null)
        {
            Console.WriteLine("No users available.");
            return;
        }

        Console.WriteLine("\nAll Users:");
        UserNode temp = head;
        while (temp != null)
        {
            DisplayUser(temp);
            temp = temp.Next;
        }
    }

    // Helper Method
    private void DisplayUser(UserNode user)
    {
        Console.WriteLine($"ID: {user.UserId}, Name: {user.Name}, Age: {user.Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SocialNetwork network = new SocialNetwork();
        int choice;

        do
        {
            Console.WriteLine("\n==== Social Media Friend Connections ====");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Search User by ID");
            Console.WriteLine("3. Search User by Name");
            Console.WriteLine("4. Add Friend Connection");
            Console.WriteLine("5. Remove Friend Connection");
            Console.WriteLine("6. Display Friends of User");
            Console.WriteLine("7. Find Mutual Friends");
            Console.WriteLine("8. Count Friends for Each User");
            Console.WriteLine("9. Display All Users");
            Console.WriteLine("10. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int id1, id2, age;
            string name;

            switch (choice)
            {
                case 1:
                    Console.Write("User ID: ");
                    id1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    network.AddUser(id1, name, age);
                    break;

                case 2:
                    Console.Write("Enter User ID: ");
                    id1 = Convert.ToInt32(Console.ReadLine());
                    var user = network.SearchById(id1);
                    if (user != null)
                        Console.WriteLine($"ID: {user.UserId}, Name: {user.Name}, Age: {user.Age}");
                    else
                        Console.WriteLine("User not found.");
                    break;

                case 3:
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
                    network.SearchByName(name);
                    break;

                case 4:
                    Console.Write("Enter User ID 1: ");
                    id1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter User ID 2: ");
                    id2 = Convert.ToInt32(Console.ReadLine());
                    network.AddFriendConnection(id1, id2);
                    break;

                case 5:
                    Console.Write("Enter User ID 1: ");
                    id1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter User ID 2: ");
                    id2 = Convert.ToInt32(Console.ReadLine());
                    network.RemoveFriendConnection(id1, id2);
                    break;

                case 6:
                    Console.Write("Enter User ID: ");
                    id1 = Convert.ToInt32(Console.ReadLine());
                    network.DisplayFriends(id1);
                    break;

                case 7:
                    Console.Write("Enter User ID 1: ");
                    id1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter User ID 2: ");
                    id2 = Convert.ToInt32(Console.ReadLine());
                    network.FindMutualFriends(id1, id2);
                    break;

                case 8:
                    network.CountFriends();
                    break;

                case 9:
                    network.DisplayAllUsers();
                    break;

                case 10:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 10);
    }
}
