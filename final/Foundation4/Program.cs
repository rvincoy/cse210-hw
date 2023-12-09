using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities=new List<Activity>();
        String choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Calculate Summary for Cycling");  
            Console.WriteLine("  2. Calculate Summary for Running");
            Console.WriteLine("  3. Calculate Summary for Swimming");
            Console.WriteLine("  4. Summary of Activities");              
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice=Console.ReadLine();
            if (choice=="1")
               activities.Add(DoCycling());
            else if (choice=="2")
                activities.Add(DoRunning());
            else if (choice=="3")
                activities.Add(DoSwimming());
            else if (choice=="4")
                ActivitiesSummary(activities);
        } while (choice!="5");
    }
    public static Cycling DoCycling()
    {
        Console.Clear();
        Console.Write("Cycling Activity\n\n");
        string date;
        int duration;
        double speed;
        Console.Write("Enter Date : ");
        date = Console.ReadLine();
        Console.Write("Enter Duration (minutes): ");
        duration = int.Parse(Console.ReadLine());
        Console.Write("Enter Speed (kph): ");
        speed = double.Parse(Console.ReadLine());        
        Cycling cycling = new Cycling(date, duration, speed);
        return cycling;
    }
    public static Running DoRunning()
    {
        Console.Clear();
        Console.Write("Running Activity\n\n");
        string date;
        int duration;
        double distance;
        Console.Write("Enter Date: ");
        date = Console.ReadLine();
        Console.Write("Enter Duration (minutes): ");
        duration = int.Parse(Console.ReadLine());
        Console.Write("Enter Distance (km): ");
        distance = double.Parse(Console.ReadLine());        
        Running running = new Running(date, duration, distance);
        return running;
    }
    public static Swimming DoSwimming()
    {
        Console.Clear();
        Console.Write("Swimming Activity\n\n");
        string date;
        int duration;
        double laps;
        Console.Write("Enter Date: ");
        date = Console.ReadLine();
        Console.Write("Enter Duration (minutes): ");
        duration = int.Parse(Console.ReadLine());
        Console.Write("Enter Laps: ");
        laps = double.Parse(Console.ReadLine());        
        Swimming swimming = new Swimming(date, duration, laps);
        return swimming;
    }
    public static void ActivitiesSummary(List<Activity> activities)
    {
        Console.Clear();
        Console.Write("Activities Summary\n\n");
        int a=1;
        foreach (Activity activity in activities)
        {
            Console.WriteLine(a + ". " + activity.Summary());
            a++;
        }
        Console.ReadLine();
    }
}