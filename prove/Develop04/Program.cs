using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;
        int sportingLog = 0;

        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Session");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingLog}");
            Console.WriteLine($"Listing Activity: {listingLog}");
            Console.WriteLine($"Sporting activity {sportingLog}");
            Console.WriteLine();
        }

        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("Here is the Menu Options:");
            Console.WriteLine("Choose between 1-4 or press 5 to quit");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Sport activity");
            Console.WriteLine("5. Quit");
            Console.Write("You can choose your choice from the menu options: ");

            input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.PromptBreathing();
                    breathingActivity.EndActivity();

                    breathingLog++;
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.RunActivity();
                    reflectingActivity.PromptReflecting();
                    reflectingActivity.EndActivity();

                    reflectingLog++;
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.PromptListing();
                    listingActivity.EndActivity();

                    listingLog++;
                    break;

                    case "4":
                    SportActivity sportActivity = new SportActivity();
                    sportActivity.RunActivity();
                    sportActivity.PromptSport();
                    sportActivity.EndActivity();

                    sportingLog++;
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter the number of the menu options. ");
                    break;
            }
        }
        Environment.Exit(0);
    }
}

/*

 Showing Creativity and exceeding the core requirements here is the following:
 * I added Tracking activity logs (breathingLog, reflectingLog, and listingLog) and displaying them using the DisplayLog function.
 * I Implementing a sports activity (SportActivity) with a list of sports and prompting the user to choose their favorite.

*/