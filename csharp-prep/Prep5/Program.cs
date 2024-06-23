using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }

        static int SquareNumber(int num)
        {
            int SquareNumber = num * num;
            return SquareNumber;
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        Console.Write($"{userName}, the square of your number is {squareNumber}");
    }
}