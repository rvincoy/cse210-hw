using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade: ");
        int grade=int.Parse(Console.ReadLine());
        string letterGrade;
       if (grade>=90)
       {
            letterGrade="A";
       }
       else if (grade>=80)
       {
            letterGrade="B";
       }
       else if (grade>=70)
       {
            letterGrade="C";
       }
       else if (grade>=60)
       {
            letterGrade="D";
       }       
        else
       {
            letterGrade="F";
       }
       int remainder = grade % 10;
       string symbol="";
       if (remainder>=7)
       {
            symbol="+";
       }
       else if (remainder<3)
       {
            symbol="-";
       }
       if ((letterGrade=="A" && symbol=="+") || letterGrade=="F")
       {
            symbol="";
       }
       Console.WriteLine("The letter grade is " + letterGrade + symbol);
   }
}