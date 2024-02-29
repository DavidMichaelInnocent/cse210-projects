using System;

class Program
{
    static void Main(string[] args)
    {
        {
           Console.WriteLine("Please Enter a list of  numbers: type 0 when finished.");
        }
        List<int> numbers = new List<int>();

        int getnumber = -1;
        while (getnumber != 0)
        {

            Console.Write("Enter a numbers: ");

            string reponse = Console.ReadLine();
            getnumber = int.Parse(reponse);

            if ( getnumber != 0)
            {
                numbers.Add(getnumber);
            }
        }
        int summ = 0;
        foreach (int number in numbers)
        {
            summ += number;
 
        }
        Console.WriteLine($"The sum is: {summ}");

        float avernumber = ((float)summ) / numbers.Count;
        Console.WriteLine($"The average is: {avernumber}");

        int maxnumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxnumber)
            {
                maxnumber = number;

            }
        }
        Console.WriteLine($"The largest number is: {maxnumber}");
    }
}