public class Reception : Event
{
    private string _rsvpEmail;
    private string _register;
    private int _capacity;
    public Reception()
    {
        _rsvpEmail="";
        _register="";
        _capacity=0;
    }
    public Reception(string eventTitle, string description, string date, string time, string rsvpEmail, string register, int capacity) : base(eventTitle,description,date,time)
    {
        _rsvpEmail=rsvpEmail;
        _register=register;
        _capacity=capacity;
    }
    public string GetRSVPEmail()
    {
        return _rsvpEmail;
    }
    public string GetRegister()
    {
        return _register;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetRSVPEmail(string rsvpEmail)
    {
        _rsvpEmail=rsvpEmail;
    }
    public void SetRegister(string register)
    {
        _register=register;
    }
    public void SetCapacity(int capacity)
    {
        _capacity=capacity;
    }
}