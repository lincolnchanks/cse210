class Scripture
{
    private List<Word> _words = new List<Word>();
    // private string _referenceString;
    private Reference _reference;

    public Scripture(Reference reference, string scriptureText)
    {
        // Split the text into a list and feed it into _words
        string[] scriptureWords = scriptureText.Split(" ");
        foreach (string word in scriptureWords)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
        _reference = reference;
        // _referenceString = reference.GetReferenceString();
    }
    public void DisplayScripture()
    {
        // Displays the Scripture's Reference and text.
        Console.WriteLine(GetScriptureReference());
        string scriptureTextString = "";
        foreach (Word w in _words)
        {
            scriptureTextString += $"{w.GetWordString()} ";
        }
        Console.WriteLine(scriptureTextString);
    }
    public string GetScriptureReference()
    {
        return _reference.GetReferenceString();
    }
}