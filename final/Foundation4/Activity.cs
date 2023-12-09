public abstract class Activity
{
    private string _date;
    private int _duration;
    public Activity()
    {
        _date="";
        _duration=0;
    }
    public Activity(string date, int duration)
    {
        _date=date;
        _duration=duration;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public double GetDurationHrs()
    {
        return _duration/60;
    }
    public abstract double ComputeDistance();
    public abstract double ComputeSpeed();
    public abstract double ComputePace();
    public abstract string Summary();
}