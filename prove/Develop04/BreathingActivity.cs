public class BreathingActivity:Activity
{
    public BreathingActivity()
    {
        base.SetName("Breathing Activity");
        base.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void DoBreathingActivity()
    {
        int x=base.GetDuration()/6;
        int x1=6;
        for (int a=0;a<x;a++)
        {
            Console.Write("\n");
            Console.Write("Breathe in...");
            for (int a1=0;a1<x1;a1++)
            {
                Console.Write(x1-a1);
                Thread.Sleep(500);
                Console.Write("\b");
            }
            Console.Write("\b ");
            Console.WriteLine(" ");
            Console.Write("Now breathe out...");
            for (int a1=0;a1<x1;a1++)
            {
                Console.Write(x1-a1);
                Thread.Sleep(500);
                Console.Write("\b");
            }
            Console.Write("\b ");
            Console.WriteLine(" ");
        }
    }
}