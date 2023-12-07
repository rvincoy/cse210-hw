public class Cycling : Activity
{
    private double _speed;
    public Cycling()
    {
        _speed=0;
    }
    public Cycling(string date, int length, double speed) : base(date,length)
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