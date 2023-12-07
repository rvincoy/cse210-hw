public abstract class Activity
{
    private string _date;
    private int _length;
    public Activity()
    {
        _date="";
        _length=0;
    }
    public Activity(string date, int length)
    {
        _date=date;
        _length=length;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }
    public abstract float ComputeDistance();
    public abstract float ComputeSpeed();
    public abstract float ComputePace();
    public abstract string Summary();
}