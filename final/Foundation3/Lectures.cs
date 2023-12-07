public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures()
    {
        _speaker="";
        _capacity=0;
    }
    public Lectures(string eventTitle, string description, string date, string time, string speaker, int capacity) : base(eventTitle,description,date,time)
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
}