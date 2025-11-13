class Word
{
    // private List<string> _characters = new List<string>();
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

    public string GetWordString()
    {
        int wordLength = _word.Length;
        string hiddenString = "";
        if (!_isHidden)
        {
            return _word;
        }
        else
        {
            for (int i = 0; i < wordLength; i++)
            {
                hiddenString += "_";
            }
            return hiddenString;
        }
    }

    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }
}