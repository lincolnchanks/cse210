class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _fileString;
    public string[] _promptStrings =
    {
        "Prompt 1",
        "Prompt 2",
        "Prompt 3"
    };

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}");
        Console.WriteLine($"{_response}");
    }
    public string CreateEntry(string date, string prompt, string response)
    {
        return $"{date}: {prompt}\n{response}";
    }
    public void CreateEntry() //Method that turns the entry into a string meant for the file
    {
        // Get date
        Console.Write("Enter today's date (mm/dd/yyyy): ");
        string dateString = Console.ReadLine();

        // Get prompt
        Random randomGenerator = new Random();
        int promptNum = randomGenerator.Next(_promptStrings.Length);
        string currentPrompt = _promptStrings[promptNum];

        Console.WriteLine(currentPrompt);

        // Get response
        Console.Write("Response: ");
        string responseString = Console.ReadLine();

        // Save Values
        _date = dateString;
        _prompt = currentPrompt;
        _response = responseString;
    }
    public string CreateFileSystemString()
    {
        _fileString = $"{_date}#{_prompt}#{_response}";
        return _fileString;
    }
}