// For creativity: I made an extra option so the user can choose to go through all activities in a row without going back to the menu inbetween.

using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        while (userChoice != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start a breathing activity");
            Console.WriteLine("2. Start a reflecting activity");
            Console.WriteLine("3. Start a listing activity");
            Console.WriteLine("4. Do all activities");
            Console.WriteLine("5. Quit");
            string userChoiceString = Console.ReadLine();
            userChoice = int.Parse(userChoiceString);
            if (userChoice == 1)
            {
                Console.WriteLine("How many seconds do you want to do this activity?: ");
                string userTimeString = Console.ReadLine();
                int userTime = int.Parse(userTimeString);

                BreathingActivity breathing = new BreathingActivity("breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", userTime);

                breathing.Run("breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", userTime);

            }
            if (userChoice == 2)
            {
                Console.WriteLine("How many seconds do you want to do this activity?: ");
                string userTimeString = Console.ReadLine();
                int userTime = int.Parse(userTimeString);

                ReflectingActivity reflecting = new ReflectingActivity("reflecting activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userTime);

                reflecting.Run("reflecting activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userTime);
            }
            if (userChoice == 3)
            {
                Console.WriteLine("How many seconds do you want to do this activity?: ");
                string userTimeString = Console.ReadLine();
                int userTime = int.Parse(userTimeString);

                ListingActivity listing = new ListingActivity("listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", userTime);

                listing.Run("listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", userTime);
               
            }

             if (userChoice == 4)
            {
                Console.WriteLine("How many seconds do you want to do each activity?: ");
                string userTimeString = Console.ReadLine();
                int userTime = int.Parse(userTimeString);

                BreathingActivity breathing = new BreathingActivity("breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", userTime);

                breathing.Run("breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", userTime);

                ReflectingActivity reflecting = new ReflectingActivity("reflecting activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userTime);

                reflecting.Run("reflecting activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userTime);

                ListingActivity listing = new ListingActivity("listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", userTime);

                listing.Run("listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", userTime);
               
            }

        }

        

        

        

        
        
        
    }
}