using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?: ");
        string percentString = Console.ReadLine();
        int percent = int.Parse(percentString);

        if (percent >= 90) 
        {
            Console.WriteLine($"Your grade is: A");
        }
        else if ((percent < 90) && (percent >= 80)) 
        {
            Console.WriteLine($"Your grade is: B");
        }
        else if ((percent < 80) && (percent >= 70)) 
        {
            Console.WriteLine($"Your grade is: C");
        }
        else if ((percent < 70) && (percent >= 60)) 
        {
            Console.WriteLine($"Your grade is: D");
        }
        else 
        {
            Console.WriteLine($"Your grade is: D");
        }

        if (percent >= 70) 
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
            Console.WriteLine("You didn't pass, better luck next time!");
        }

    }
}