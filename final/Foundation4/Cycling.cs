public class Cycling : Activity
{
    private double _speed;
    public Cycling()
    {
        _speed=0;
    }
    public Cycling(string date, int duration, double speed) : base(date,duration)
    {
        _speed=speed;
    }
    public double GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(double speed)
    {
        _speed=speed;
    }
    public override double ComputeDistance()
    {
        return ComputeSpeed()*30/60;
    }
    public override double ComputeSpeed()
    {
        return _speed;
    }
    public override double ComputePace()
    {
        return base.GetDuration()/ComputeDistance();
    }
    public override string Summary()
    {
        string a = base.GetDate() + " Cycling (" + base.GetDuration() + " min): Distance: " + ComputeDistance() + " km, ";
        a = a + "Speed: " + ComputeSpeed() + " kph, Pace: " + ComputePace() + " min per km";
        return a;
    }   
}