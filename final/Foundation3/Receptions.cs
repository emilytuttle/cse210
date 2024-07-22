public class Receptions : Event
{
    private string _email;

    public Receptions(string eventTitle, string description, string date, string time, string address, string email) : base (eventTitle, description, date, time, address)
    {
        _email = email;
    }

   
   public void DisplayFullDetails()
   {
    Console.WriteLine("Full Details:");
    Console.WriteLine($"{_eventTitle}");
    Console.WriteLine($"{_description}");
    Console.WriteLine($"{_date} at {_time}");
    Console.WriteLine($"{_address}");
    Console.WriteLine($"Contact us at {_email} to RSVP!");
   }
}