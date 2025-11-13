class Reference
{
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    public string GetReferenceString()
    {
        return $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
    }
}