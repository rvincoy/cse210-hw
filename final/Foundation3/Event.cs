public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address = new Address();
    public Event()
    {
        _eventTitle="";
        _description="";
        _date="";
        _time="";
    }
    public Event(string eventTitle, string description, string date, string time)
    {
        _eventTitle=eventTitle;
        _description=description;
        _date=date;
        _time=time;
    }
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle=eventTitle;
    }
    public void GetDescription(string description)
    {
        _description=description;
    }
    public void GetDate(string date)
    {
        _date=date;
    }
    public void GetTime(string time)
    {
        _time=time;
    }
    public void GetAddress(Address address)
    {
        _address=address;
    }
    public string StandardDetails()
    {
        return "";
    }
    public string FullDetails()
    {
        return "";
    }
    public string ShortDescription()
    {
        return "";
    }
}