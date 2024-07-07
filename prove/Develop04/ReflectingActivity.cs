public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
            { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string>
            { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
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

    public string GetRandomQuestion() 
    {
        int highNum = _questions.Count -1;       
        Random randomGenerator = new Random();
        int questionIndex = randomGenerator.Next(0, highNum);
        string randomQuestion = _questions [questionIndex];
        Console.WriteLine(randomQuestion);
        return randomQuestion;
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
        DisplaySpinner(5);

        var startTime = DateTime.UtcNow;
        while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(duration))
        {
            GetRandomQuestion();
            DisplaySpinner(5);
            
        }

        Console.WriteLine();

        DisplayEndingMessage(duration, name);

        DisplaySpinner(5);

    }

}

