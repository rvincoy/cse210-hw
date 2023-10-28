using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int num;
        DisplayWelcome();
        name = PromptUserName();
        num = PromptUserNumber();
        num = SquareNumber(num);
        DisplayResult(name,num);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        string name;
        Console.Write("Please enter your name: ");
        name=Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        int num;
        Console.Write("Please enter your favorite number: ");
        num=int.Parse(Console.ReadLine());
        return num;        
    }
    static int SquareNumber(int num)
    {
        return num*num;
    }
    static void DisplayResult(string name, int num)
    {
        Console.WriteLine(name + ", the square of your number is " + num);
    }
}