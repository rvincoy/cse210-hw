public class Activity
{
    private String _name;
    private String _description;
    private int _duration;
    public void SetName(string name)
    {
        _name=name;
    }
    public void SetDescription(string desc)
    {
        _description=desc;
    }
    public void SetDuration(int duration)
    {
        _duration=duration;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n\n");
        Console.Write("How long, in seconds, would you like for your session? ");
    }
    public void DisplayBeginActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.Write("\\ ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("| ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("/ ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("- ");
        Thread.Sleep(500);
        Console.Write("\b\b ");
    }
    public void DisplayEndActivity()
    {
        Console.WriteLine("\nWell done!!");
        Console.Write("\\ ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("| ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("/ ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("- ");
        Thread.Sleep(500);
        Console.Write("\b\b ");
        Console.WriteLine($"\nYou have completed another {_duration} of the {_name}.");
        Console.Write("\\ ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("| ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("/ ");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("- ");
        Thread.Sleep(500);
        Console.Write("\b\b ");
    }
}