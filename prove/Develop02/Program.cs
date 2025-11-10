using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();

        Menu journalMenu = new Menu();

        int userSelection;

        bool done = false;

        do
        {
            userSelection = journalMenu.ProcessMenu();

            switch(userSelection)
            {
                case 1:
                    Entry currentEntry = new Entry();
                    currentEntry.CreateEntry();
                    currentJournal._entries.Add(currentEntry);
                // Create a new Entry Object
                // Call create on that object
                // Add the entry to the journal
                    break;
                case 2:
                    currentJournal.Display();
                // Call journal.Display();
                    break;
                case 3:
                    currentJournal.SaveToFile();
                // Save to a file
                    break;
                case 4:
                // Read from a file
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);

    }
}