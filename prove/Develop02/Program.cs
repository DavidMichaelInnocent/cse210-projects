using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal
        Journal journal = new Journal();

        // Display a welcome message
        Console.WriteLine("Welcome to the Journal App!");

        // Create a variable to store the user's choice
        int choice = 0;

        // Create a loop to display the menu until the user exits
        while (choice != 5)
        {
            // Display the menu options
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            // Get the user's choice as an integer
            choice = int.Parse(Console.ReadLine());

            // Handle the user's choice using a switch statement
            switch (choice)
            {
                case 1:
                    // Call the AddEntry method of the journal
                    journal.AddEntry();
                    break;
                case 2:
                
                    // Call the DisplayJournal method of the journal
                    journal.DisplayJournal();
                    break;
                case 3:
                    // Call the SaveJournal method of the journal
                    journal.SaveJournal();
                    break;
                case 4:
                    // Call the LoadJournal method of the journal
                    journal.LoadJournal();
                    break;
                case 5:
                    // Display a farewell message and exit the loop
                    Console.WriteLine("Thank you for using the Journal App!");
                    break;
                default:
                    // Display an error message for invalid choices
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}