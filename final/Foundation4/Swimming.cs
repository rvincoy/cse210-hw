public class Swimming : Activity
{
    private double _laps;
    public Swimming()
    {
        _laps=0;
    }
    public Swimming(string date, int duration, double laps) : base(date,duration)
    {
        _laps=laps;
    }
    public double GetLaps()
    {
        return _laps;
    }
    public void SetLaps(double laps)
    {
        _laps=laps;
    }
    public override double ComputeDistance()
    {
        return _laps * 50 / 1000;
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
        string a = base.GetDate() + " Swimming (" + base.GetDuration() + " min): Distance: " + ComputeDistance() + " km, ";
        a = a + "Speed: " + ComputeSpeed() + " kph, Pace: " + ComputePace() + " min per km";
        return a;
    }   
}