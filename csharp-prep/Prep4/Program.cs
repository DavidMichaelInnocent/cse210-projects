using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 

        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);

        numbers.RemoveAt(numbers.Count - 1); 

        
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();

        
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The average is: {0:F4}", average);
        Console.WriteLine("The largest number is: {0}", max);

       
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine("The smallest positive number is: {0}", smallestPositive);
        }
    }
}