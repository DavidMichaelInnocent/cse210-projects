using System;

namespace MyScripture
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a scripture to memorize:");
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. John 3:16");
            Console.Write("Enter your choice (1 or 2): ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Scripture scripture;

            if (choice == 1)
            {
                scripture = new Scripture("Proverb", 3, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6: In all thy ways acknowledge him, and he shall direct thy paths.");
            }
            else if (choice == 2)
            {
                scripture = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life .");
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