public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine($"{_eventTitle}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"{_address}");
    }

     public void ListShortDetails(string eventType)
    {
        Console.WriteLine("Short Details");
        Console.WriteLine($"Event: {eventType}, {_eventTitle}, {_date}");
    }
}