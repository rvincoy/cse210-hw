public class Reception : Event
{
    private string _rsvpEmail;
    public Reception()
    {
        _rsvpEmail="";
    }
    public Reception(string eventTitle, string description, string date, string time, string rsvpEmail) : base(eventTitle,description,date,time)
    {
        _rsvpEmail=rsvpEmail;
    }
    public string GetRSVPEmail()
    {
        return _rsvpEmail;
    }
    public void SetRSVPEmail(string rsvpEmail)
    {
        _rsvpEmail=rsvpEmail;
    }
    public override string FullDetails()
    {
        string a;
        a=base.StandardDetails();
        a=a+ "\nRSVP Email : " + _rsvpEmail;
        return a;
    }
    public override string ShortDescription()
    {
        string a;
        a="Event Type : Reception\n";
        a=a+ "Title : " + base.GetEventTitle() + "\n";
        a=a+ "Date : " + base.GetDate();
        return a;
    }
    public override string SaveFile()
    {
        string a;
        Address address = base.GetAddress();
        a = "Reception~|~" + base.GetEventTitle() + "~|~" + base.GetDescription() + "~|~" + base.GetDate() + "~|~" + base.GetTime() + "~|~";
        a = a + address.GetStreetAddress()  + "~|~" + address.GetCity()  + "~|~" + address.GetStateProvince()  + "~|~" + address.GetCountry()  + "~|~";
        a = a + _rsvpEmail;
        return a;
    }
}