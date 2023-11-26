public class SimpleGoal:Goal
{
    private bool _complete=false;
    public SimpleGoal(string goal, string description, int points):base(goal,description,points)
    {

    }
    public override bool IsComplete()
    {
        return _complete;
    }
    public override void RecordEvent()
    {
        _complete = true;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetGoal()},{base.GetDescription()},{base.GetPoints()},{IsComplete().ToString()}";
    }
}