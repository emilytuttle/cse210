public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures(string eventTitle, string description, string date, string time, string address, string speakerName, int capacity) : base (eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

   
   public void DisplayFullDetails()
   {
    Console.WriteLine("Full Details:");
    Console.WriteLine($"{_eventTitle}");
    Console.WriteLine($"{_description}");
    Console.WriteLine($"{_date} at {_time}");
    Console.WriteLine($"{_address}");
    Console.WriteLine($"Our speaker will be {_speakerName}");
    Console.WriteLine($"Capacity of {_capacity} guests");
   }
}