using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int answer = int.Parse(Console.ReadLine());

        Random radogener = new Random();
        int magnum = radogener.Next(1, 101);

        int guest = -1;

        while (guest != magnum)
        {
            Console.Write("What is your guess number? ");
            guest = int.Parse(Console.ReadLine());

            if (magnum > guest)
            {
                Console.WriteLine("Higher");
            }
            else if(magnum < guest)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congrats, You guess it!");
            }
        }
    }
}