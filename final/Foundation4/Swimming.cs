public class Swimming : Activity
{
    private double _laps;
    public Swimming()
    {
        _laps=0;
    }
    public Swimming(string date, int length, double laps) : base(date,length)
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