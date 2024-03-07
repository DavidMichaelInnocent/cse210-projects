using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // Initialize list to store numbers

        // Get user input for numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);

        numbers.RemoveAt(numbers.Count - 1); // Remove the last 0 entered by the user

        // Calculate sum, average, and maximum
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        // Stretch challenge: smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();

        // Display results
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The average is: {0:F4}", average);
        Console.WriteLine("The largest number is: {0}", max);

        // Stretch challenge: sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Optional: display smallest positive number (if any)
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine("The smallest positive number is: {0}", smallestPositive);
        }
    }
}