public class Word
{
    private string _text;
    private int _hidden;

    public Word(string text, int hidden)
    {
        _text = text;
        _hidden = hidden;
    }

    public void SetText(string text)
    {
        _text = text;
    }
    public void SetHidden(int hidden)
    {
        _hidden = hidden;
    }
    public string GetText()
    {
        return _text;
    }
    public int GetHidden()
    {
        return _hidden;
    }
    public int Length()
    {
        return _text.Length;
    }
}