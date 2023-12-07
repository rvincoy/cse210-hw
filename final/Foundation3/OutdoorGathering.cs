public class OutdoorGathering : Event
{
    private string _weatherForecast;
    public OutdoorGathering()
    {
        _weatherForecast="";
    }
    public OutdoorGathering(string eventTitle, string description, string date, string time, string weatherForecast) : base(eventTitle,description,date,time)
    {
        _weatherForecast=weatherForecast;
    }
    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }
    public void SetWeatherForecast(string weatherForecast)
    {
        _weatherForecast=weatherForecast;
    }
}