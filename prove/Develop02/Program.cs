using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string currentDate = theCurrentTime.ToShortDateString();
        
        Entry entry = new Entry();

        Journal journal = new Journal();

        PromptGenerator prompt = new PromptGenerator();
        
        int userDecision = -10000;
        while (userDecision !=5)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do?: ");
            string userDecisionString = Console.ReadLine();
            userDecision = int.Parse(userDecisionString);

            if (userDecision == 1)
            {
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write(">");
                string currentEntry = Console.ReadLine();
            
                if (currentEntry == "")
                {
                    entry._entryText = "no entry";
                }
                else
                {
                    entry._entryText = currentEntry;
                }
                entry._date = currentDate;
                journal.SaveToFile(entry._date, entry._promptText, entry._entryText);

            }
            else if (userDecision == 2)
            {
                journal.DisplayAll();
            }
            else if (userDecision == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Would you like to load from journal.txt? 1. Yes, 2. No");
                Console.Write("What would you like to do?: ");
                string userDecisionStringThree = Console.ReadLine();
                int userDecisionThree = int.Parse(userDecisionStringThree);
                if (userDecisionThree == 1)
                {
                    Console.WriteLine("Loaded from journal.txt");
                }
                else
                {
                    Console.WriteLine("journal.txt is the only file available");
                }
            }
            else if (userDecision == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Would you like to save to journal.txt? 1. Yes, 2. No");
                Console.Write("What would you like to do?: ");
                string userDecisionStringFour = Console.ReadLine();
                int userDecisionFour = int.Parse(userDecisionStringFour);
                if (userDecisionFour == 1)
                {
                    Console.WriteLine("Saved to journal.txt");
                }
                else
                {
                    Console.WriteLine("journal.txt is the only file available");
                }
            }
            
        }
    }
}