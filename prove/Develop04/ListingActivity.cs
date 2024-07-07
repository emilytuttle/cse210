public class ListingActivity : Activity
{
    private int _count = 0;

    private List<string> _prompts = new List<string>
            { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are some of your personal heroes?", "Who are people that you have helped this week?" };
   
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public string GetRandomPrompt() 
    {
        int highNum = _prompts.Count -1;       
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, highNum);
        string randomPrompt = _prompts [promptIndex];
        Console.WriteLine(randomPrompt);
        return randomPrompt;
    }

   

    public void Run(string name, string description, int duration)
    {
        Console.Clear();
        DisplayStartingMessage(name);
        Console.WriteLine();
        Console.WriteLine(description);
        DisplaySpinner(5);
        Console.WriteLine();

        GetRandomPrompt();
        Console.WriteLine();
        DisplayCountdownSeconds(5);

        var startTime = DateTime.UtcNow;
        while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(duration))
        {
            int block = _count;
            if (_count <= block )
            {
                Console.Write(">");
                Console.ReadLine();
                _count += 1;
            }
            
        }

        Console.WriteLine();
        Console.WriteLine($"You wrote {_count} things");
        Console.WriteLine();

        DisplayEndingMessage(duration, name);

        DisplaySpinner(5);

    }

}

