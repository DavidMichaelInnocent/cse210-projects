using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        Console.WriteLine("Enter your grade percentage: ");
        string input = Console.ReadLine();
        double grade;

        
        if (!double.TryParse(input, out grade))
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade.");
            return;
        }

        
        string letterGrade = DetermineLetterGrade(grade);
        string passMessage = grade >= 70 ? "Congratulations! You passed the course." : "Keep at it, and you'll succeed next time!";

        
        Console.WriteLine($"Your grade is {letterGrade}. {passMessage}");
    }

    static string DetermineLetterGrade(double grade)
    {
        string letter;

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

        
        if (letter != "F" && letter != "A")
        {
            char sign = grade % 10 >= 7 ? '+' : (grade % 10 < 3 ? '-' : ' ');
            letter += sign;
        }

        
        letter = grade >= 100 ? "A" : (grade < 0 ? "F" : letter);

        return letter;
    }
}