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

    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }
}