using System.Dynamic;

public class Question
{
    private int _index;
    private string _question;
    private bool _asked;

    public Question(int index, string question, bool asked)
    {
        _question=question;
        _asked=asked;
    }
    public string GetQuestion()
    {
        return _question;
    }
    public bool GetAsked()
    {
        return _asked;
    }
    public void SetAsked(bool asked)
    {
        _asked=asked;
    }
}