public class ChecklistGoal:Goal
{
    private int _target;
    private int _bonus;
    private int _timesCompleted=0;
    public ChecklistGoal(string goal, string description, int points, int target, int bonus):base(goal,description,points)
    {
        _target = target;
        _bonus = bonus;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted=timesCompleted;
    }
    public void IncrementTimesCompleted()
    {
        _timesCompleted = _timesCompleted + 1;
    }
    public override bool IsComplete()
    {
        bool temp=false;
        if (GetTimesCompleted()>=_target)
            temp = true;
        return temp;
    }
    public override void RecordEvent()
    {
        IncrementTimesCompleted();
    }
    public override string GetDetailString()
    {
        string mark;
        if (IsComplete())
            mark="X";
        else
            mark=" ";
        return $"[{mark}] {base.GetGoal()} ({base.GetDescription()}) -- Currently completed {GetTimesCompleted()}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetGoal()},{base.GetDescription()},{base.GetPoints()},{_bonus},{_target},{GetTimesCompleted()}";
    }
    public override bool AwardExtraPoints()
    {
        bool temp=false;
        if (GetTimesCompleted()==_target)
            temp = true;
        return temp;
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public override int GetTarget()
    {
        return _target;
    }
}