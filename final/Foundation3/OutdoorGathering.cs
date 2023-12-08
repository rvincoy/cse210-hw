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

    public override string FullDetails()
    {
        string a;
        a=base.StandardDetails();
        a=a+ "\nWeather Forecast : " + _weatherForecast;
        return a;
    }
    public override string ShortDescription()
    {
        string a;
        a="Event Type : Outdoor Gathering\n";
        a=a+ "Title : " + base.GetEventTitle() + "\n";
        a=a+ "Date : " + base.GetDate();
        return a;
    }
    public override string SaveFile()
    {
        string a;
        Address address = base.GetAddress();
        a = "OutdoorGathering~|~" + base.GetEventTitle() + "~|~" + base.GetDescription() + "~|~" + base.GetDate() + "~|~" + base.GetTime() + "~|~";
        a = a + address.GetStreetAddress()  + "~|~" + address.GetCity()  + "~|~" + address.GetStateProvince()  + "~|~" + address.GetCountry()  + "~|~";
        a = a + _weatherForecast;
        return a;
    }
}