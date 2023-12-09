public class Running : Activity
{
    private double _distance;
    public Running()
    {
        _distance=0;
    }
    public Running(string date, int duration, double distance) : base(date,duration)
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
    public override double ComputeDistance()
    {
        return _distance;
    }
    public override double ComputeSpeed()
    {
        return ComputeDistance()/base.GetDuration()*60;
    }
    public override double ComputePace()
    {
        return base.GetDuration()/ComputeDistance();
    }
    public override string Summary()
    {
        string a = base.GetDate() + " Running (" + base.GetDuration() + " min): Distance: " + ComputeDistance() + " km, ";
        a = a + "Speed: " + ComputeSpeed() + " kph, Pace: " + ComputePace() + " min per km";
        return a;
    }   
}