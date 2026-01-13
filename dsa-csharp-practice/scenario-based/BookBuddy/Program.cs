using System;
class Program
{
    static void Main()
    {
        // Object created through interface (Loose Coupling)
        IBookManager manager = new BookUtility();

        Menu menu = new Menu(manager);
        menu.ShowMenu();
    }
}
