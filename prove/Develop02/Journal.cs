using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    // A list of journal entries
    private List<JournalEntry> entries;

    // An array of prompts
    private string[] prompts = new string[]
    {
        "What did I learn today?",
        "What am I grateful for today?",
        "How did I overcome a challenge today?",
        "What made me laugh today?",
        "What did I do today that I am proud of?",
        // Add more prompts here
    };

    // A constructor that creates an empty journal
    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    // A method that adds a new entry to the journal
    public void AddEntry()
    {
        // Choose a random prompt
        Random random = new Random();
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];

        // Show the prompt and get the user's response
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Enter your response (press Enter twice to end):");
        string response = "";
        string line = "";
        do
        {
            line = Console.ReadLine();
            response += line + "\n";
        } while (line != "");

        // Create a new journal entry and add it to the list
        JournalEntry entry = new JournalEntry(prompt, response);
        entries.Add(entry);

        // Show a confirmation message
        Console.WriteLine("Entry added successfully.");
    }

    // A method that shows the journal
    public void DisplayJournal()
    {
        // Check if the journal is empty
        if (entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        // Show each entry in the journal
        Console.WriteLine("Your journal has {0} entries.", entries.Count);
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine();
        }
    }

    // A method that saves the journal to a file
    public void SaveJournal()
    {
        // Ask the user for a filename
        Console.WriteLine("Enter a filename to save your journal:");
        string filename = Console.ReadLine();

        // Check if the filename is valid
        if (string.IsNullOrEmpty(filename))
        {
            Console.WriteLine("Invalid filename.");
            return;
        }

        // Create a string to store the journal content
        string content = "";

        // Append each entry to the string, separated by a symbol
        string separator = "~|~"; // You can change this to any symbol you like
        foreach (JournalEntry entry in entries)
        {
            content += entry.Date + separator;
            content += entry.Prompt + separator;
            content += entry.Response + separator;
            content += "\n";
        }

        // Write the string content to the file
        File.WriteAllText(filename, content);

        // Show a confirmation message
        Console.WriteLine("Journal saved to {0}.", filename);
    }

    // A method that loads the journal from a file
    public void LoadJournal()
    {
        // Ask the user for a filename
        Console.WriteLine("Enter a filename to load your journal:");
        string filename = Console.ReadLine();

        // Check if the filename is valid
        if (string.IsNullOrEmpty(filename))
        {
            Console.WriteLine("Invalid filename.");
            return;
        }

        // Check if the file exists
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        // Read the file content as a string
        string content = File.ReadAllText(filename);

        // Split the content by newlines
        string[] lines = content.Split('\n');

        // Clear the current journal entries
        entries.Clear();

        // Parse each line as a journal entry
        foreach (string line in lines)
        {
            // Split the line by the separator symbol
            string[] parts = line.Split();

            // Check if the line has three parts
            if (parts.Length == 3)
            {
                // Get the date, prompt, and response from the parts
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                // Create a new journal entry object with the date, prompt, and response
                JournalEntry entry = new JournalEntry(prompt, response);

                // Set the date of the entry to the date from the file
                entry.Date = date;

                // Add the entry to the list of entries
                entries.Add(entry);
            }
        }

        // Show a confirmation message
                Console.WriteLine("Journal loaded from {0}.", filename);
    }
}