class Scripture
{
    public List<Word> _words = new List<Word>();
    public string _referenceString;
    public Reference _reference;

    public Scripture(List<Word> words, Reference reference)
    {
        _words = words;
        _reference = reference;
        _referenceString = reference.GetReferenceString();
    }
    public void DisplayScripture()
    {
        Console.WriteLine(_referenceString);
        string scriptureTextString = "";
        foreach (Word w in _words)
        {
            scriptureTextString += $"{w.GetWordString()} ";
        }
        Console.WriteLine(scriptureTextString);
    }
}