using System.Data;

public class LogActivity
{
    private string _date;
    private string _activity;
    private int _duration;
    public LogActivity(string date, string activity, int duration)
    {
        _date=date;
        _activity=activity;
        _duration=duration;
    }
    public void SetDate(string date)
    {
        _date=date;
    }
    public void SetDuration(int duration)
    {
        _duration=duration;
    }
    public void SetActivity(string activity)
    {
        _activity=activity;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetActivity()
    {
        return _activity;
    }
}