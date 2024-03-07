using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        DisplayWelcome();

        
        string name = PromptUserName();

        
        int favoriteNumber = PromptUserNumber();

        
        int squaredNumber = SquareNumber(favoriteNumber);

        
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine("{0}, the square of your number is {1}", name, squaredNumber);
    }
}