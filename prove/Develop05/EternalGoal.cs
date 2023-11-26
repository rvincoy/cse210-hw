public class EternalGoal:Goal
{
    public EternalGoal(string goal, string description, int points):base(goal,description,points)
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override void RecordEvent()
    {
        
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetGoal()},{base.GetDescription()},{base.GetPoints()}";
    }
}