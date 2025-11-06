using System.Runtime.InteropServices;

public class Menu
{
    public string[] _menuStrings =
    {
        "Welcome to the Journal",
        "You can create, display, save, and read journal entries.",
        "1 - Create Journal Entry",
        "2 - Display Journal",
        "3 - Save Entry to File",
        "4 - Read Journal Entries from File",
        "5 - Quit"
    };

    /* Process Menu will display the menu to the user and read and validate the input,
    and return the input. There are no parameters received in this function. */
    public int ProcessMenu()
    {
        int userSelection;
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            userSelection = int.Parse(Console.ReadLine());
        }
        while (userSelection < 1 || userSelection > 5);
        return userSelection;
    }
}