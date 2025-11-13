class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool GetIsHidden() // Get method
    {
        return _isHidden;
    }

    public void HideWord() // Set isHidden
    {
        _isHidden = true;
    }

    private string LocalGetWordString()
    {
        // If the word isn't hidden, return it. If it is,
        // return the hidden version of it.
        int wordLength = _word.Length;
        string hiddenString = "";
        if (_isHidden)
        {
            for (int i = 0; i < wordLength; i++)
            {
                hiddenString += "_";
            }
            return hiddenString;
        }
        else
        {
            return _word;
        }
    }

    public void DisplayWord()
    {
        Console.Write(LocalGetWordString());
    }

    public string GetWordString()
    {
        return LocalGetWordString();
    }
}