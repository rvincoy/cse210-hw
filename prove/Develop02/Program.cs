using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        JournalEntry journalEntry = new JournalEntry();
        int a=0;
        do
        {
            a = MenuPrompt();
            if (a==1)
            { //Write
                journalEntry = Write();
               journal._journalEntry.Add(journalEntry);
            }
            else if (a==2)
            { //Display
                journal.DisplayAttribute();
            }
            else if (a==3)
            { //Load
                journal=OpenFile();
            }
            else if (a==4)
            { //Save
                SaveFile(journal);
            }
            else if (a==5)
            { //Quit

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        } while (a!=5);

    }

    public static int MenuPrompt()
    {
        int num;
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");        
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");        
        Console.Write("What would you like to do? ");  
        num=int.Parse(Console.ReadLine());
        return num;
    }
    public static JournalEntry Write()
    {
        JournalEntry journalEntry=new JournalEntry();
        Random rnd = new Random();
        DateTime date = DateTime.Now;
        int num = rnd.Next(5);
        if (num==0)
        {
            Console.WriteLine("Who was the most interesting person I interacted with today?");
            Console.Write("> ");
            journalEntry._prompt="Who was the most interesting person I interacted with today?";
            journalEntry._entryDate=date.ToString("d");
            journalEntry._entry=Console.ReadLine();
        }
        else if (num==1)
        {
            Console.WriteLine("What was the best part of my day?");
            Console.Write("> ");
            journalEntry._prompt="What was the best part of my day?";
            journalEntry._entryDate=date.ToString("d");
            journalEntry._entry=Console.ReadLine();
        }
        else if (num==2)
        {
            Console.WriteLine("How did I see the hand of the Lord in my life today?");
            Console.Write("> ");
            journalEntry._prompt="How did I see the hand of the Lord in my life today?";
            journalEntry._entryDate=date.ToString("d");
            journalEntry._entry=Console.ReadLine();
        }
        else if (num==3)
        {
            Console.WriteLine("What was the strongest emotion I felt today?");
            Console.Write("> ");
            journalEntry._prompt="What was the strongest emotion I felt today?";
            journalEntry._entryDate=date.ToString("d");
            journalEntry._entry=Console.ReadLine();
        }
        else if (num==4)
        {
            Console.WriteLine("If I had one thing I could do over today, what would it be?");
            Console.Write("> ");
            journalEntry._prompt="If I had one thing I could do over today, what would it be?";
            journalEntry._entryDate=date.ToString("d");
            journalEntry._entry=Console.ReadLine();
        }                        
        return journalEntry;
    }
    public static void SaveFile(Journal journal)
    {
        string filename="";
        Console.WriteLine("What is the filename?");
        filename=Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry journalEntry in journal._journalEntry)
            {
                outputFile.WriteLine(journalEntry._entryDate + "~|~" + journalEntry._prompt + "~|~" + journalEntry._entry);
            }
        }

    }
    public static Journal OpenFile()
    {
        Journal journal = new Journal();
        string filename="";
        Console.WriteLine("What is the filename?");        
        filename=Console.ReadLine();        
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            JournalEntry journalEntry = new JournalEntry();
            journalEntry._entryDate=parts[0];
            journalEntry._prompt=parts[1];
            journalEntry._entry=parts[2];
            journal._journalEntry.Add(journalEntry);
        }
        return journal;
    }
}