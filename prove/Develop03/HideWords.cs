public class HideWords
{
    private string _theText;
    private List<Word> _words = new List<Word>();
    private int _length;

    public HideWords(string text)
    {
        _theText = text;
        string[] words = text.Split(" ");
        int i=0;
        foreach (string word in words)
        {
            _words.Add(new Word(word,0));
            i++;
        }
        _length=i;
    }
    private string Dashes(string word)
    {
        string temp="";
        for (int i=0; i<word.Length; i++)
        {
            temp=temp+"_";
        }
        return temp;
    }
    public int GetLength()
    {
        return _length;
    }
    public int GetHiddenCount()
    {
        return SumHidden();
    }
    private int SumHidden()
    {
        int sum=0;
        foreach (Word word in _words)
        {
            sum = sum + word.GetHidden();
        }
        return sum;
    }
    public void Redact()
    {
        string temp;
        Random rnd = new Random();
        int num;
        foreach (Word word in _words)
        {
            num = rnd.Next(5);
            temp="";

            if (num>=3)
            {
                temp = Dashes(word.GetText());
                word.SetHidden(1);
                word.SetText(temp);
            }
            else if (GetHiddenCount()>=23)
            {
                temp = Dashes(word.GetText());
                word.SetHidden(1);
                word.SetText(temp);
            }
        }
    }
    public string GetWords()
    {
        string temp="";
        foreach (Word word in _words)
        {
            temp=temp+word.GetText()+" ";
        }
        _theText=temp;
        return _theText;
    }
}