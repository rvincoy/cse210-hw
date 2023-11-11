public class Reference
{
    private string _scriptRef;
    private string _scriptText;

    public Reference()
    {
        setVar("","");
    }
    public Reference(string scriptref, string scriptText)
    {
       setVar(scriptref,scriptText);
    }

    public void setVar(string scriptref, string scriptText)
    {
        _scriptRef = scriptref;
        _scriptText = scriptText;
    }
    public string GetRef()
    {
        return _scriptRef;
    }
    public string GetText()
    {
        return _scriptText;
    }
    public void AddScripture(string scriptref, string scriptText)
    {
        if (GetBook(_scriptRef) == GetBook(scriptref) && GetChapter(_scriptRef) == GetChapter(scriptref))
        {
            _scriptRef = _scriptRef + "-" + GetVerse(scriptref);
        }
        else
        {
            _scriptRef = _scriptRef + "; " + scriptref;
        }
        _scriptText = _scriptText + " " + scriptText;
    }
    private string GetBook(string scriptref)
    {
        return scriptref.Substring(0,scriptref.IndexOf(" "));
    }
    private int GetChapter(string scriptref)
    {
        return int.Parse(scriptref.Substring(scriptref.IndexOf(" "),scriptref.IndexOf(":")-scriptref.IndexOf(" ")));
    }
    private int GetVerse(string scriptref)
    {
        return int.Parse(scriptref.Substring(scriptref.IndexOf(":")+1,scriptref.Length-scriptref.IndexOf(":")-1));
    }
}