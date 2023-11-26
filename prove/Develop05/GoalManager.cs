public class GoalManager
{
    private int _points;
    private List<Goal> _goals = new List<Goal>();
    public GoalManager()
    {
        _points=0;
    }
    public int GetPoints()
    {
        return _points;
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public void IncrementPoints(int points)
    {
        _points=_points+points;
    }
    public void Start()
    {
        int choice;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");  
            Console.WriteLine("  2. List Goals"); 
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice=int.Parse(Console.ReadLine());
            if (choice==1)
                CreateGoal();
            else if (choice==2)
                ListGoalDetails();
            else if (choice==3)
                SaveGoals();
            else if (choice==4)
                _goals=LoadGoals();
            else if (choice==5)
                RecordEvent();
        } while (choice!=6);

    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_points} points.\n");
    }
    private void CreateGoal()
    {
        int choice,points,bonus,target;
        string goal,description;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");  
        Console.WriteLine("  2. Eternal Goal"); 
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        choice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        goal=Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description=Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points=int.Parse(Console.ReadLine());
        if (choice==3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target=int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus=int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(goal,description,points,target,bonus));
        }
        else if (choice==2)
        {
            _goals.Add(new EternalGoal(goal,description,points));
        }
        else
        {
            _goals.Add(new SimpleGoal(goal,description,points));            
        }
    }
    private void ListGoalDetails()
    {
        int num=1;
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            Console.Write($"{num}. ");
            Console.WriteLine(goal.GetDetailString());
            num++;
        }
    }
    private void ListGoalNames()
    {
        int num=1;
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            Console.Write($"{num}. ");
            Console.WriteLine(goal.GetGoal());
            num++;
        }
    }
    private void SaveGoals()
    {
        string filename="";
        Console.Write("What is the filename? ");
        filename=Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_points);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    private List<Goal> LoadGoals()
    {
        string filename="";
        int a=1;
        List<Goal> goals = new List<Goal>();
        Console.Write("What is the filename? ");        
        filename=Console.ReadLine();
        _points = int.Parse(System.IO.File.ReadLines(filename).First());
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            if (a!=1)
            {
                string[] data = parts[1].Split(",");
                if (parts[0]=="SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(data[0],data[1],int.Parse(data[2]));
                    if (data[3]=="True")
                        simpleGoal.RecordEvent();
                    goals.Add(simpleGoal);
                }
                else if (parts[0]=="EternalGoal")
                    goals.Add(new EternalGoal(data[0],data[1],int.Parse(data[2])));
                else
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(data[0],data[1],int.Parse(data[2]),int.Parse(data[4]),int.Parse(data[3]));
                    checklistGoal.SetTimesCompleted(int.Parse(data[5]));
                    goals.Add(checklistGoal);
                }
            }
            a++;
        }
        return goals;
    }
    private void RecordEvent()
    {
        int choice;
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        choice = int.Parse(Console.ReadLine());
        _goals[choice-1].RecordEvent();
        _points = _points + _goals[choice-1].GetPoints();
        Console.WriteLine("Congratulations! You have earned " + _goals[choice-1].GetPoints() + " points!");
        if (_goals[choice-1].AwardExtraPoints())
        {
            _points = _points + _goals[choice-1].GetBonus();
            Console.WriteLine("Congratulations! You have earned " + _goals[choice-1].GetBonus() + " bonus points for completing your goal " + _goals[choice-1].GetTarget() + " times!");
        }
        Console.WriteLine($"You now have {_points} points.\n");
    }
}