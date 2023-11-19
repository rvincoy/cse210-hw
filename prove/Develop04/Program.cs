using System;

class Program
{
    static void Main(string[] args)
    {
        String choice;
        List<LogActivity> logs = new List<LogActivity>();
        logs = OpenFile();
        int a;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");  
            Console.WriteLine("  2. Start reflecting activity"); 
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("  5. Summarize Log");
            Console.Write("Select a choice from the menu: ");
            choice=Console.ReadLine();
            if (choice=="1")
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartMessage();
                a=int.Parse(Console.ReadLine());
                breathingActivity.SetDuration(a);
                breathingActivity.DisplayBeginActivity();
                breathingActivity.DoBreathingActivity();
                breathingActivity.DisplayEndActivity();
                logs.Add(new LogActivity(DateTime.Now.ToString(),"Breathing Activity",breathingActivity.GetDuration()));
            }
            else if (choice=="2")
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.DisplayStartMessage();
                a=int.Parse(Console.ReadLine());
                reflectionActivity.SetDuration(a);
                reflectionActivity.DisplayBeginActivity();
                reflectionActivity.DoReflectionActivity();
                reflectionActivity.DisplayEndActivity();
                logs.Add(new LogActivity(DateTime.Now.ToString(),"Reflection Activity",reflectionActivity.GetDuration()));
            }
            else if (choice=="3")
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartMessage();
                a=int.Parse(Console.ReadLine());
                listingActivity.SetDuration(a);
                listingActivity.DisplayBeginActivity();
                listingActivity.DoListingActivity();
                listingActivity.DisplayEndActivity();
                logs.Add(new LogActivity(DateTime.Now.ToString(),"Listing Activity",listingActivity.GetDuration()));
            }
            else if (choice=="5")
            {
                Console.Clear();
                SummarizeLog(logs);
            }
        } while (choice!="4");
        SaveFile(logs);
    }
    public static void SaveFile(List<LogActivity> logs)
    {
        string filename="activitylog.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (LogActivity log in logs)
            {
                outputFile.WriteLine(log.GetDate() + "~|~" + log.GetActivity() + "~|~" + log.GetDuration());
            }
        }

    }
    public static List<LogActivity> OpenFile()
    {
        List<LogActivity> logs = new List<LogActivity>();
        string filename="activitylog.txt";       
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            logs.Add(new LogActivity(parts[0],parts[1],int.Parse(parts[2])));
        }
        return logs;
    }
    public static void SummarizeLog(List<LogActivity> logs)
    {
        int countLogs=0;
        int countBreathe=0;
        int countReflect=0;
        int countList=0;
        int durationLogs=0;
        int durationBreathe=0;
        int durationReflect=0;
        int durationList=0;

        foreach (LogActivity log in logs)
        {
            countLogs++;
            durationLogs=durationLogs+log.GetDuration();
            if (log.GetActivity()=="Breathing Activity")
            {
                countBreathe++;
                durationBreathe=durationBreathe+log.GetDuration();
            }
            else if (log.GetActivity()=="Reflection Activity")
            {
                countReflect++;
                durationReflect=durationReflect+log.GetDuration();
            }
            else
            {
                countList++;
                durationList=durationList+log.GetDuration();
            }
        }
        Console.Clear();
        Console.WriteLine("Logs Summary");
        Console.WriteLine($"Breathing Activity => {countBreathe} times for a total of {durationBreathe} seconds.");
        Console.WriteLine($"Reflection Activity => {countReflect} times for a total of {durationReflect} seconds.");
        Console.WriteLine($"Listing Activity => {countList} times for a total of {durationList} seconds.");
        Console.WriteLine($"All Activities => {countLogs} times for a total of {durationLogs} seconds.");
        Console.ReadLine();
    }
}      