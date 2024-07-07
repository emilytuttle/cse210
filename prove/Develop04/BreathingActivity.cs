public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    
    }

    public void Run(string name, string description, int duration)
    {
        Console.Clear();
        DisplayStartingMessage(name);
        Console.WriteLine();
        Console.WriteLine(description);
        DisplaySpinner(5);
        Console.WriteLine();

        var startTime = DateTime.UtcNow;
        while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(duration))
        {
            Console.WriteLine("Breath in... ");
            DisplayCountdownSeconds(4);
            Console.Write("\b \b");
            Console.WriteLine("Breath out... ");
            DisplayCountdownSeconds(4);
            Console.Write("\b \b");
            Console.WriteLine();
        }

        DisplayEndingMessage(duration, name);

        DisplaySpinner(5);

    }
}