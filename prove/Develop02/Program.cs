using System;

namespace Journal_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "What was the best part of my day?",
                "How did i see the hand of the lord in my life todsy?",
                "What was the stongest emotion i felt today?",
                "If had one thing to do over today, what could it be?",
                "How as the Book Of Mormon helps you develope your faith in Jesus Christ?",
                "Did you believe that God is our eternal father?",
                "Did you believe that Jesus Christ is the son of God?",
                "How have you strongest develope your faith in Savior Jesus Christ?",
                "When last did you study come follow me manual?",
                "When last did you experience obstacle in your life?",
                "Did have testimony about The church of JESUS CHRIST of later-day saint?",
                "Write anything that could be a life remembrace for you."
            };

            bool abort = false;
            while (!abort)
            {
                Console.WriteLine("\nWelcome to the Daily_Journal Program App!");
                
                Console.WriteLine("\nWhat do you want to do, select your choice just number from 1 to 4.:");
                
                Console.WriteLine("1. New_Write.");
                Console.WriteLine("2. Display_Write.");
                Console.WriteLine("3. Save_Write.");
                Console.WriteLine("4. Load_Save");
                Console.WriteLine("5. Quit_App");

                Console.WriteLine("\nWhat would you like to do today? ");
                Console.WriteLine();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        abort = true;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice Retry Back.");
                        break;
                }
            }

            
            Console.WriteLine("Come back latter an try again, thanks!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}

// Show creativity and Exceed the requirements. I Write  Save other information in the journal entry. 
// It accomplishes this by creating an Entry class that stores the date, prompt, and user response. 
// This information is then saved to a CSV file using the SaveToFile method which will allow the user to open the save_files in Excel app, and can be use.
