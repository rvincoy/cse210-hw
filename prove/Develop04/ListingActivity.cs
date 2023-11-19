public class ListingActivity:Activity
{
    public ListingActivity()
    {
        base.SetName("Listing Activity");
        base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
    public void DoListingActivity()
    {
        Random rnd = new Random();
        int num = rnd.Next(5);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.Write("\n--- ");
        if (num==0)
        {
            Console.WriteLine("Who are people that you appreciate? ---");
        }
        else if (num==1)
        {
            Console.WriteLine("What are personal strengths of yours? ---");
        }
        else if (num==2)
        {
            Console.WriteLine("Who are people that you have helped this week? ---");
        }
        else if (num==3)
        {
            Console.WriteLine("When have you felt the Holy Ghost this month? ---");
        }
        else if (num==4)
        {
            Console.WriteLine("Who are some of your personal heroes? ---");
        }
        Console.Write("You may begin in: ");
        Console.Write("6");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("5");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("4");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("3");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("2");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("1");
        Thread.Sleep(500);
        Console.WriteLine("\b ");
        string ans;
        num=0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        do
        {
            ans=Console.ReadLine();
            num++;
            startTime = DateTime.Now;
        } while (futureTime>startTime);
        Console.WriteLine($"You listed {num} items.");
    }
}