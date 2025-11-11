class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _fileString;
    public string[] _promptStrings =
    {
        "Who was the most interesting person you interacted with today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "What was the best part of your day?"
    }; // Creativity: allow the user to choose one prompt to answer
    // Also, get the date from the operating system

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}");
        Console.WriteLine($"{_response}");
    }
    public string CreateEntry(string date, string prompt, string response)
    {
        // Sets the attributes AND returns a string.
        _date = date;
        _prompt = prompt;
        _response = response;
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