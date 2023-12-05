using System;
using System.Transactions;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        String choice;
        List<Video> videos = new List<Video>();
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a Video Record");  
            Console.WriteLine("  2. Create a Video Comment"); 
            Console.WriteLine("  3. Save to File");
            Console.WriteLine("  4. Load from File");
            Console.WriteLine("  5. Display Data");
            Console.WriteLine("  6. Display Full Data");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            choice=Console.ReadLine();
            if (choice=="1")
                videos.Add(AddVideo());
            else if (choice=="2")
                videos = AddComment(videos);
            else if (choice=="3")
                SaveFile(videos);
            else if (choice=="4")
                videos=OpenFile();    
            else if (choice=="5")
                DisplayData(videos);
            else if (choice=="6")
                DisplayDataFull(videos);
        } while (choice!="7");
    }
    public static Video AddVideo()
    {
        Console.Clear();
        string title;
        string author;
        int length;
        Console.Write("Enter Title: ");
        title=Console.ReadLine();
        Console.Write("Enter Author: ");
        author=Console.ReadLine();
        Console.Write("Enter Length: ");
        length=int.Parse(Console.ReadLine());
        Video video=new Video(title,author,length);
        return video;
    }
    public static List<Video> AddComment(List<Video> videos)
    {
        int a=1;
        int b=0;
        Console.Clear();
        Console.WriteLine("Video Lists");
        foreach (Video video in videos)
        {
            Console.WriteLine($"{a}. {video.VideoInfo()}");
            a++;
        }
        Console.Write("Write the number that corresponds with the video you want to put a comment to: ");
        b=int.Parse(Console.ReadLine());
        string name;
        string text;
        Console.Write("\n\nName: ");
        name=Console.ReadLine();
        Console.Write("Text: ");
        text=Console.ReadLine();
        videos[b-1].AddComment(name,text);
        return videos;
    }
    public static void DisplayData(List<Video> videos)
    {
        Console.Clear();
        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.VideoInfo()}. This video has {video.CountComments()} comments.");
        }
        Thread.Sleep(3000);
    }
    public static void DisplayDataFull(List<Video> videos)
    {
        Console.Clear();
        foreach (Video video in videos)
        {
                List<Comment> comments = new List<Comment>();
                comments = video.GetComments();
                if (video.CountComments()==0)
                    Console.WriteLine($"{video.VideoInfo()}");
                foreach (Comment comment in comments)
                {
                    Console.Write($"{video.VideoInfo()}");
                    Console.WriteLine($"; Comment Name : {comment.GetName()}; Comment Text : {comment.GetText()}");
                }
        }
        Thread.Sleep(3000);
    }
   public static void SaveFile(List<Video> videos)
    {
        string filename="";
        Console.Clear();
        Console.WriteLine("What is the filename?");
        filename=Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Video video in videos)
            {
                List<Comment> comments = new List<Comment>();
                comments = video.GetComments();
                if (video.CountComments()==0)
                     outputFile.WriteLine($"{video.GetTitle()}~|~{video.GetAuthor()}~|~{video.GetLength()}~|~~|~");               
                foreach (Comment comment in comments)
                {
                    outputFile.WriteLine($"{video.GetTitle()}~|~{video.GetAuthor()}~|~{video.GetLength()}~|~{comment.GetName()}~|~{comment.GetText()}");
                }
            }
        }
        Console.WriteLine("File has been saved to "+ filename);
        Thread.Sleep(1500);
    }
    public static List<Video> OpenFile()
    {
        List<Video> videos = new List<Video>();
        string filename="";
        Console.Clear();
        Console.WriteLine("What is the filename?");        
        filename=Console.ReadLine();        
        string[] lines = System.IO.File.ReadAllLines(filename);
        string title1="";
        string author1="";
        int length1=0;
        Video video = new Video();
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts[0]!=title1 && parts[1]!=author1 && int.Parse(parts[2])!=length1)
            {
                if (video.GetTitle()!="")
                {
                    videos.Add(video);
                    Video video1 = new Video();
                    video = video1;
                }
                title1 = parts[0];
                author1 = parts[1];
                length1 = int.Parse(parts[2]);
                video.SetTitle(parts[0]);
                video.SetAuthor(parts[1]);
                video.SetLength(int.Parse(parts[2]));
                if (parts[3]=="" && parts[4]=="")
                {
                    videos.Add(video);
                    Video video1 = new Video();
                    video = video1;                  
                }
                else
                    video.AddComment(parts[3],parts[4]);
            }
            else
            {
                video.SetTitle(parts[0]);
                video.SetAuthor(parts[1]);
                video.SetLength(int.Parse(parts[2]));
                video.AddComment(parts[3],parts[4]);
            }
        }
        if (video.GetTitle()!="")
            videos.Add(video);
        return videos;
    }
}