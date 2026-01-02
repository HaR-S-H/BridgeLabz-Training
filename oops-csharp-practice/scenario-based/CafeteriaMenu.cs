using System;

class CafeteriaMenuApp
{
    static string[] menuItems =
    {
        "Veg Sandwich",
        "Cheese Burger",
        "Pasta",
        "French Fries",
        "Pizza Slice",
        "Cold Coffee",
        "Tea",
        "Idli",
        "Dosa",
        "Veg Thali"
    };

    // Method to display menu
    static void DisplayMenu()
    {
        Console.WriteLine("------ Cafeteria Menu ------");

        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine(i + " : " + menuItems[i]);
        }
    }

    // Method to get item by index
    static string GetItemByIndex(int index)
    {
        if (index >= 0 && index < menuItems.Length)
        {
            return menuItems[index];
        }
        else
        {
            return "Invalid menu selection";
        }
    }

    static void Main()
    {
        DisplayMenu();

        Console.Write("\nEnter item index to order: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        string selectedItem = GetItemByIndex(choice);

        Console.WriteLine("\nYou selected: " + selectedItem);
        Console.ReadLine();
    }
}
