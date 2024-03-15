using System;

namespace MyScripture
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine(" Welcome to the scripture memorize! Choose your preffer scripture to memorize:");
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. John 3:16");
            Console.Write("Enter your choice (1 or 2): ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Scripture scripture;

            if (choice == 1)
            {
                scripture = new Scripture("Proverb", 3, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \n6: In all thy ways acknowledge him, and he shall direct thy paths.");
            }
            else if (choice == 2)
            {
                scripture = new Scripture("John", 3, 16, "`` For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. ` `");
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to end.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nCongrats, you got this Scripture memorization!");
                    Console.WriteLine();
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to end.");
            }
        }
    }
}

/*
Show creativity and Exceeded requirement.
1. I Offering a Choice of Scriptures:
 * The program lets the user choose from two scriptures to memorize, rather than just working with a single one.
2. Allowing for Multiple Verses:
 * It can handle scriptures with multiple verses, such as "Proverbs 3:5-6", demonstrating flexibility in scripture selection.
3. Preventing Repetition of Already-Hidden Words:
 * When selecting random words to hide, it only chooses from words that are not already hidden, making the memorization process more challenging and effective.
*/