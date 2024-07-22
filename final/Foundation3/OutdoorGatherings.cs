public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string eventTitle, string description, string date, string time, string address, string weather) : base (eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

   
   public void DisplayFullDetails()
   {
    Console.WriteLine("Full Details:");
    Console.WriteLine($"{_eventTitle}");
    Console.WriteLine($"{_description}");
    Console.WriteLine($"{_date} at {_time}");
    Console.WriteLine($"{_address}");
    Console.WriteLine($"Remember, the weather will be {_weather}!");
   }
}