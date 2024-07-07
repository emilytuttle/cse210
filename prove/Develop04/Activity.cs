public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage(string activity)
    {
        Console.WriteLine($"Welcome to the {activity}.");
    }

    public void DisplaySpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        // Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        
        if (currentTime < futureTime)
        {
            Thread.Sleep(1000);
        Console.Write("-");

        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write(@"\"); 

        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|");

        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");

        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");

        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("");
        }
    }

    public void DisplayEndingMessage(int number, string activity)
    {
        Console.WriteLine("Well Done!");

        DisplaySpinner(5);
        
        Console.WriteLine();
       
        Console.WriteLine($"You have completed {number} seconds of {activity}.");
    }

    public void DisplayCountdownSeconds(int number)
    {
        while (number > 0)
        {
            Console.Write($"{number}"); 
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
 
            number -= 1;
        }
    }
}