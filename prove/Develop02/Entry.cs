using System;



public class Entry
{

    public string _promptText;
    public string _entryText;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Prompt: {_promptText}, Entry: {_entryText}, Date: {_date}");
    }
    
}