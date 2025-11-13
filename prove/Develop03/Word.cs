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
    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }
}