using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        string cont="yes";
        int number, cnt, guess;
        while (cont=="yes")
        {
            Console.Write("What is the magic number? ");
            number = int.Parse(Console.ReadLine());
            cnt=0;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                cnt++;
                if (number<guess)
                {
                    Console.WriteLine("Lower");
                }
                else if (number>guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess!=number);
            Console.WriteLine("You guess " + cnt + " times.");
            Console.Write("Enter yes to continue: ");
            cont=Console.ReadLine();
        }
    }
}