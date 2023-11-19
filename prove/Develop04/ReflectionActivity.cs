public class ReflectionActivity:Activity
{
    public ReflectionActivity()
    {
        base.SetName("Reflection Activity");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
    public void DoReflectionActivity()
    {
        int xQuestions=base.GetDuration()/6;
        Random rnd = new Random();
        List<Question> questions = new List<Question>();
        int num = rnd.Next(4);
        Console.WriteLine("\nConsider the following prompt:");
        Console.Write("\n--- ");
        if (num==0)
        {
            Console.WriteLine("Think of a time when you stood up for someone else. ---");
        }
        else if (num==1)
        {
            Console.WriteLine("Think of a time when you did something really difficult. ---");
        }
        else if (num==2)
        {
            Console.WriteLine("Think of a time when you helped someone in need. ---");
        }
        else if (num==3)
        {
            Console.WriteLine("Think of a time when you ddi something truly selfless. ---");
        }
        questions.Add(new Question(0,"Why was this experience meaningful to you?",false));
        questions.Add(new Question(1,"Have you ever done anything like this before?",false));
        questions.Add(new Question(2,"How did you get started?",false));
        questions.Add(new Question(3,"How did you feel when it was complete?",false));
        questions.Add(new Question(4,"What made this time different than other times when you were not as successful",false));
        questions.Add(new Question(5,"What is your favorite thing about this experience?",false));
        questions.Add(new Question(6,"What could you learn from this experience that applies to other situations?",false));
        questions.Add(new Question(7,"What did you learn about yourself through this experience?",false));
        questions.Add(new Question(8,"How can you keep this experience in mind in the future?",false));
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        int x=0;
        do
        {
            num = rnd.Next(9);
            if (questions[num].GetAsked()==false)
            {
                questions[num].SetAsked(true);
                Console.Write("\n" + questions[num].GetQuestion() + "....");
                Console.Write("\\ ");
                Thread.Sleep(1500);
                Console.Write("\b\b");
                Console.Write("| ");
                Thread.Sleep(1500);
                Console.Write("\b\b");
                Console.Write("/ ");
                Thread.Sleep(1500);
                Console.Write("\b\b");
                Console.Write("- ");
                Thread.Sleep(1500);
                Console.Write("\b\b ");
                x++;
            }
        } while (x<xQuestions);

    }
}