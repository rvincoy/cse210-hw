public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture()
    {
        _speaker="";
        _capacity=0;
    }
    public Lecture(string eventTitle, string description, string date, string time, string speaker, int capacity) : base(eventTitle,description,date,time)
    {
        _speaker=speaker;
        _capacity=capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker=speaker;
    }
    public void SetCapacity(int capacity)
    {
        _capacity=capacity;
    }
    public override string FullDetails()
    {
        string a;
        a=base.StandardDetails();
        a=a+ "\nSpeaker Name : " + _speaker + "\n";
        a=a+ "Capacity : " + _capacity;
        return a;
    }
    public override string ShortDescription()
    {
        string a;
        a="Event Type : Lectures\n";
        a=a+ "Title : " + base.GetEventTitle() + "\n";
        a=a+ "Date : " + base.GetDate();
        return a;
    }
    public override string SaveFile()
    {
        string a;
        Address address = base.GetAddress();
        a = "Lecture~|~" + base.GetEventTitle() + "~|~" + base.GetDescription() + "~|~" + base.GetDate() + "~|~" + base.GetTime() + "~|~";
        a = a + address.GetStreetAddress()  + "~|~" + address.GetCity()  + "~|~" + address.GetStateProvince()  + "~|~" + address.GetCountry()  + "~|~"; 
        a = a + _speaker + "~|~" + _capacity;
        return a;
    }
}