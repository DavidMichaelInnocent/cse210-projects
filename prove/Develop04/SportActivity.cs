using System;

public class SportActivity : Activity
{
    private List<string> _sports = new List<string> {
        "Soccer",
        "Basketball",
        "Tennis",
        "Cricket",
        "Baseball",
        "Rugby",
        "Table Tennis",
        "Volleyball"
    };

    public SportActivity()
    {
        SetName("Sport Activity");
        SetDescription("Choose your favorite sport from the list.");
    }

    public void PromptSport()
    {
        Console.WriteLine("\nChoose your favorite sport:");
        for (int i = 0; i < _sports.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_sports[i]}");
        }
        Console.Write("Enter the number of your favorite sport: ");
        
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= _sports.Count)
        {
            Console.WriteLine($"Your favorite sport is: {_sports[choice - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
