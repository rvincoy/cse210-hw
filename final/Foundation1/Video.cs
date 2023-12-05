using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video()
    {
        _title="";
        _author="";
        _length=0;
    }
    public Video(string title, string author, int length)
    {
        _title=title;
        _author=author;
        _length=length;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetTitle(string title)
    {
        _title=title;
    }
    public void SetAuthor(string author)
    {
        _author=author;
    }
    public void SetLength(int length)
    {
        _length=length;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void AddComment(string name, string text)
    {
        if (name!="" && text!="")
        {
            Comment comment=new Comment(name,text);
            _comments.Add(comment);
        }
    }
    public int CountComments()
    {
        int a=0;
        foreach(Comment comment in _comments)
        {
            a++;
        }
        return a;
    }
    public string VideoInfo()
    {
        return $"Title : {_title}; Author : {_author}; Length : {_length}";
    }
}
