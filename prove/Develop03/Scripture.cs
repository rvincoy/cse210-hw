public class Scripture
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _text;
    private string _reference;
    
    public Scripture()
    {
    }
    public Scripture(string book, int chapter, int verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = text;
        ComputeReference();
    }

    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public string GetText()
    {
        return _text;
    }
    public string GetReference()
    {
        ComputeReference();
        return _reference; 
    }
    private void ComputeReference()
    {
        _reference = _book + " " + _chapter + ":" + _verse;
    }
}