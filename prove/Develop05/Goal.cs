public abstract class Goal
{
    private string _goal;
    private string _description;
    private int _points;
    public Goal(string goal, string description, int points)
    {
        _goal = goal;
        _description = description;
        _points = points;
    }
    public string GetGoal()
    {
        return _goal;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public virtual string GetDetailString()
    {
        string mark;
        if (IsComplete())
            mark="X";
        else
            mark=" ";
        return $"[{mark}] {_goal} ({_description})";
    }
    public abstract string GetStringRepresentation();
    public virtual bool AwardExtraPoints()
    {
        return false;
    }
    public virtual int GetBonus()
    {
        return 0;
    }
    public virtual int GetTarget()
    {
        return 0;
    }
}