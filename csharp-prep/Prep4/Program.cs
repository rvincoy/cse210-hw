using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num!=0)
            {
                numbers.Add(num);
            }
        } while (num!=0);
        int sum=0;
        int positiveMin=-1;
        int cnt=0;
        int maximum=-99999999;
        float avg;
        foreach (int number in numbers)
        {
            cnt++;
            sum=sum+number;
            if (cnt==1)
            {
                maximum=number;
            }
            if (number > maximum)
            {
                maximum=number;
            }
            if (number>0 && positiveMin==-1)
            {
                positiveMin=number;
            }
            else if (number>0 && positiveMin>number)
            {
                positiveMin=number;
            }
        }
        if (cnt>0)
        {
            avg=(float)sum/cnt;
            Console.WriteLine("The sum is: " +sum);
            Console.WriteLine($"The average is: {avg:#.###}");
            Console.WriteLine("The largest number is: " +maximum);
            Console.WriteLine("The smallest positive number is: " +positiveMin);
            Console.WriteLine("The sorted list is:");
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}