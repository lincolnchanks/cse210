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

    public void ProcessMenu()
    {
        foreach(string menuItem in _menuStrings)
        {
            // Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(menuItem);
        }
    }



    public void print(string sentence)
    {
        Console.WriteLine(sentence);
    }
}