using System.IO.Enumeration;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"{e._date}: {e._prompt}");
            Console.WriteLine($"{e._response}"); // I could have just called entry.Display();
        }
    }
    public void AddEntry()
    {

    }
    public void SaveToFile()
    {
        Console.Write("Enter the filename to save to: ");
        string outputFilehandle = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(outputFilehandle))
        {
            foreach(Entry e in _entries)
            {
                outputFile.WriteLine(e.CreateFileSystemString());
            }
        }
    }
    public void ReadFromFile()
    {
        Console.Write("Enter the file name to read: ");
        string filename = Console.ReadLine();

        string[] entryLines = System.IO.File.ReadAllLines(filename);

        foreach (string entry in entryLines)
        {
            string[] parts = entry.Split("#");

            string entryDate = parts[0];
            string entryPrompt = parts[1];
            string entryResponse = parts[2];

            Entry readEntry = new Entry();
            readEntry._fileString = readEntry.CreateEntry(entryDate, entryPrompt, entryResponse);
            _entries.Add(readEntry);
        }
    }
}