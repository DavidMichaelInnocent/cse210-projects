using System;

class Program
{
    static void Main(string[] args)
        {
        Console.Write("What is your grade percentage? ");
        string ans = Console.ReadLine();
        int grade = int.Parse(ans);
        
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your later grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation you passed the course");
        }
        else
        {
            Console.WriteLine("You don't pass it.");
        }
    }
}