public class Running : Activity
{
    private double _distance;
    public Running()
    {
        _distance=0;
    }
    public Running(string date, int length, double distance) : base(date,length)
    {
        _distance=distance;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance=distance;
    }
    public override float ComputeDistance()
    {
        return 0;
    }
    public override float ComputeSpeed()
    {
        return 0;
    }
    public override float ComputePace()
    {
        return 0;
    }
    public override string Summary()
    {
        return "";
    }   
}