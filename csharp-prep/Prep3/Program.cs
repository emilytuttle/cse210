using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int userGuess = -10000000;

        while (userGuess != number) {
            Console.Write("What's your guess?: ");
            string guessString = Console.ReadLine();
            userGuess = int.Parse(guessString);

            if (userGuess > number) 
            {
                Console.WriteLine("Too high, guess again.");
            }
            else if (userGuess < number) 
            {
                Console.WriteLine("Too low, guess again.");
            }
            else if (userGuess == number) 
            {
                Console.WriteLine("Great guess, you got it!");
            }
        }
    }
}