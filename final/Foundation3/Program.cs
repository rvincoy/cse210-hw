using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        List<Event> events = new List<Event>();
        Reception reception = new Reception();
        String choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a Lecture Event");  
            Console.WriteLine("  2. Create a Reception Event");
            Console.WriteLine("  3. Create an Outdoor Gathering Event");             
            Console.WriteLine("  4. Save to File");
            Console.WriteLine("  5. Load from File");
            Console.WriteLine("  6. Display Standard Details");
            Console.WriteLine("  7. Display Full Details");
            Console.WriteLine("  8. Display Short Description");
            Console.WriteLine("  9. Quit");
            Console.Write("Select a choice from the menu: ");
            choice=Console.ReadLine();
            if (choice=="1")
                events.Add(AddLecture());
            else if (choice=="2")
                events.Add(AddReception());
            else if (choice=="3")
                events.Add(AddOutdoorGathering());
            else if (choice=="4")
                SaveFile(events); 
            else if (choice=="5")
                events=OpenFile();    
            else if (choice=="6")
                DisplayStandardDetails(events);
            else if (choice=="7")
                DisplayFullDetails(events);
            else if (choice=="8")
                DisplayShortDescription(events);
        } while (choice!="9");
        
    }
    public static Lecture AddLecture()
    {
        Console.Clear();
        string title, description, date, time, streetAddress, city, stateProvince, country, speaker;
        int capacity;
        Console.Write("Enter Event Title: ");
        title=Console.ReadLine();
        Console.Write("Enter Description: ");
        description=Console.ReadLine();
        Console.Write("Enter Date: ");
        date=Console.ReadLine();
        Console.Write("Enter Time: ");
        time=Console.ReadLine();
        Console.Write("Enter Street Address: ");
        streetAddress=Console.ReadLine();
        Console.Write("Enter City: ");
        city=Console.ReadLine();
        Console.Write("Enter State/Province: ");
        stateProvince=Console.ReadLine();
        country="USA";
        Address address=new Address(streetAddress,city,stateProvince,country);
        Console.Write("Speaker: ");
        speaker=Console.ReadLine();        
        Console.Write("Enter Capacity: ");
        capacity=int.Parse(Console.ReadLine());
        Lecture lecture=new Lecture(title,description,date,time,speaker,capacity);
        lecture.SetAddress(address);
        return lecture;
    }
    public static Reception AddReception()
    {
        Console.Clear();
        string title, description, date, time, streetAddress, city, stateProvince, country, rsvpEmail;
        Console.Write("Enter Event Title: ");
        title=Console.ReadLine();
        Console.Write("Enter Description: ");
        description=Console.ReadLine();
        Console.Write("Enter Date: ");
        date=Console.ReadLine();
        Console.Write("Enter Time: ");
        time=Console.ReadLine();
        Console.Write("Enter Street Address: ");
        streetAddress=Console.ReadLine();
        Console.Write("Enter City: ");
        city=Console.ReadLine();
        Console.Write("Enter State/Province: ");
        stateProvince=Console.ReadLine();
        country="USA";
        Address address=new Address(streetAddress,city,stateProvince,country);
        Console.Write("RSVP Email: ");
        rsvpEmail=Console.ReadLine();        
        Reception reception=new Reception(title,description,date,time,rsvpEmail);
        reception.SetAddress(address);
        return reception;
    }    public static OutdoorGathering AddOutdoorGathering()
    {
        Console.Clear();
        string title, description, date, time, streetAddress, city, stateProvince, country, weatherForecast;
        Console.Write("Enter Event Title: ");
        title=Console.ReadLine();
        Console.Write("Enter Description: ");
        description=Console.ReadLine();
        Console.Write("Enter Date: ");
        date=Console.ReadLine();
        Console.Write("Enter Time: ");
        time=Console.ReadLine();
        Console.Write("Enter Street Address: ");
        streetAddress=Console.ReadLine();
        Console.Write("Enter City: ");
        city=Console.ReadLine();
        Console.Write("Enter State/Province: ");
        stateProvince=Console.ReadLine();
        country="USA";
        Address address=new Address(streetAddress,city,stateProvince,country);
        Console.Write("Weather Forecast: ");
        weatherForecast=Console.ReadLine();        
        OutdoorGathering outdoorGathering=new OutdoorGathering(title,description,date,time,weatherForecast);
        outdoorGathering.SetAddress(address);
        return outdoorGathering;
    }
   public static void SaveFile(List<Event> events)
    {
        string filename="";
        Console.Clear();
        Console.WriteLine("What is the filename?");
        filename=Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Event event1 in events)
            {
                outputFile.WriteLine(event1.SaveFile());               
            }
        }
        Console.WriteLine("File has been saved to "+ filename);
        Thread.Sleep(1500);
    }
    public static List<Event> OpenFile()
    {
        List<Event> events = new List<Event>();
        string filename="";
        Console.Clear();
        Console.WriteLine("What is the filename?");        
        filename=Console.ReadLine();        
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts[0]=="Lecture")
            {
                Lecture lecture=new Lecture(parts[1],parts[2],parts[3],parts[4],parts[9],int.Parse(parts[10]));
                Address address=new Address(parts[5],parts[6],parts[7],parts[8]);
                lecture.SetAddress(address);
                events.Add(lecture);
            }
            else if (parts[0]=="Reception")
            {
                Reception reception=new Reception(parts[1],parts[2],parts[3],parts[4],parts[9]);
                Address address=new Address(parts[5],parts[6],parts[7],parts[8]);
                reception.SetAddress(address);
                events.Add(reception);
            }
            else if (parts[0]=="OutdoorGathering")
            {
                OutdoorGathering outdoorGathering=new OutdoorGathering(parts[1],parts[2],parts[3],parts[4],parts[9]);
                Address address=new Address(parts[5],parts[6],parts[7],parts[8]);
                outdoorGathering.SetAddress(address);
                events.Add(outdoorGathering);
            }
        }
        return events;
    }
    public static void DisplayStandardDetails(List<Event> events)
    {
        Console.Clear();
        int a=1;
        Console.WriteLine("Standard Event Detail\n");
        foreach (Event event1 in events)
        {
            Console.WriteLine("Event " + a);
            a++;
            Console.WriteLine(event1.StandardDetails() + "\n");               
        }
        Console.ReadLine();      
    }
    public static void DisplayFullDetails(List<Event> events)
    {
        Console.Clear();
        int a=1;
        Console.WriteLine("Full Event Detail\n");
        foreach (Event event1 in events)
        {
            Console.WriteLine("Event " + a);
            a++;
            Console.WriteLine(event1.FullDetails() + "\n");               
        }
        Console.ReadLine();      
    }
    public static void DisplayShortDescription(List<Event> events)
    {
        Console.Clear();
        int a=1;
        Console.WriteLine("Event Short Description\n");
        foreach (Event event1 in events)
        {
            Console.WriteLine("Event " + a);
            a++;
            Console.WriteLine(event1.ShortDescription() + "\n");               
        }
        Console.ReadLine();      
    }
}