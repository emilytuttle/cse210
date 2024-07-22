using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("Leadership Conference", "Learn how to lead with our speaker", "June 4, 2093", "4:30pm", "1234 E Tree Way", "Sally Kelly", 150);

        Receptions reception = new Receptions("Sam and Sam's Wedding Reception", "A reception to celebration Sam & Sam Sam, Children of Cam & Jam Sam and Pam & Lamb Sam", "July 28, 2015", "6:00pm", "5543 W Sam Drive", "samsamsam@samsam.com");

        OutdoorGatherings outdoorGathering = new OutdoorGatherings("Company BBQ", "Join us to celebrate 10 years of business! We're eating hotdogs.", "September 31, 2025", "1:23am", "4903 S Company Way", "rainy");

        
        lecture.ListShortDetails("Lecture");
        Console.WriteLine("--------------");
        lecture.DisplayStandardDetails();
        Console.WriteLine("--------------");
        lecture.DisplayFullDetails();
        Console.WriteLine("-----------------------------------------------");

        reception.ListShortDetails("Reception");
        Console.WriteLine("--------------");
        reception.DisplayStandardDetails();
        Console.WriteLine("--------------");
        reception.DisplayFullDetails();
        Console.WriteLine("-----------------------------------------------");

        outdoorGathering.ListShortDetails("Outdoor Gathering");
        Console.WriteLine("--------------");
        outdoorGathering.DisplayStandardDetails();
        Console.WriteLine("--------------");
        outdoorGathering.DisplayFullDetails();
        Console.WriteLine("-----------------------------------------------");
    }
}