using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to Guess the Number!");

        // Generate a random magic number between 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guessCount = 0; // Initialize guess counter

        bool playing = true;
        while (playing)
        {
            // Get user's guess
            Console.WriteLine("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it! The magic number was {0} in {1} guesses.", magicNumber, guessCount);
                playing = PlayAgain(); // Ask to play again
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
    }

    static bool PlayAgain()
    {
        Console.WriteLine("Do you want to play again? (yes/no)");
        string answer = Console.ReadLine().ToLower();
        return answer == "yes";
    }
}