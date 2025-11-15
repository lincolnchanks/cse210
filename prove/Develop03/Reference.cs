class Reference
{
    string _book;
    int _chapter;
    string _verses;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verses = $"{startVerse}-{endVerse}";
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = $"{verse}";
    }
    public string GetReferenceString()
    {
        return $"{_book} {_chapter}:{_verses}";
    }
}