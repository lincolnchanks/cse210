using System.ComponentModel.DataAnnotations;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string scriptureText)
    {
        string[] scriptureWords = scriptureText.Split(" ");
        foreach (string word in scriptureWords)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
        _reference = reference;
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

    public void HideRandomWords()
    {
        Random scriptureRandomGen = new Random();
        for (int i = 0; i < 3; i++)
        {
            int wordIndex = scriptureRandomGen.Next(_words.Count());
            _words[wordIndex].HideWord();
        }
    }
}