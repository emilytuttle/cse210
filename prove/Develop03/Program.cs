// CREATIVITY: The user can add their own verse and memorize that instead of the one already there.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Welcome! Press enter to remove words or type 'quit'. Would you like to 1) enter your own scripture or 2) use one of ours: ");
        string userDecisionString = Console.ReadLine();
        int userDecision = int.Parse(userDecisionString);

        if (userDecision == 1) {
            Console.Write("Enter your scripture book: ");
            string userBook = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your scripture chapter: ");
            string userChapterString = Console.ReadLine();
            int userChapter = int.Parse(userChapterString);
            Console.WriteLine();
            Console.Write("Enter your scripture starting verse: ");
            string userStartingVerseString = Console.ReadLine();
            int userStartingVerse = int.Parse(userStartingVerseString);
            Console.WriteLine();
            Console.Write("Enter your scripture ending verse (if you only have one verse, enter 0): ");
            string userEndingVerseString = Console.ReadLine();
            int userEndingVerse = int.Parse(userEndingVerseString);
            Console.Write("Enter your scripture verse: ");
            string userVerseString = Console.ReadLine();
    

            Reference reference = new Reference(userBook, userChapter, userStartingVerse, userEndingVerse);
            Scripture scripture = new Scripture(reference, userVerseString);

            string quit = "";
            bool checkHidden = scripture.IsCompletelyHidden();
            Console.Clear();
            scripture.GetDisplayText();
            quit = Console.ReadLine();
            while (quit != "quit" && !checkHidden)
            
            {   
                int numToHide = 2;
                scripture.HideRandomWords(numToHide);
                scripture.GetDisplayText();
                checkHidden = scripture.IsCompletelyHidden();
                quit = Console.ReadLine();
            }
            {   
                int numToHide = 2;
                scripture.HideRandomWords(numToHide);
                scripture.GetDisplayText();
                checkHidden = scripture.IsCompletelyHidden();
                quit = Console.ReadLine();

            }
        }
        else{
            Reference reference = new Reference("Luke", 2, 16, 0);
            Scripture scripture = new Scripture(reference, "And they came with haste, and found Mary, and Joseph, and the babe lying in a manger.");
             

            string quit = "";
            bool checkHidden = scripture.IsCompletelyHidden();
            Console.Clear();
            scripture.GetDisplayText();
            quit = Console.ReadLine();
            while (quit != "quit" && !checkHidden)
            {   
                int numToHide = 2;
                scripture.HideRandomWords(numToHide);
                scripture.GetDisplayText();
                checkHidden = scripture.IsCompletelyHidden();
                quit = Console.ReadLine();
            }
        }
    }
}