using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
    
        int number = -100000;
        while (number != 0) 
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
            Console.Write("Number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            numbersList.Add(number);  
        }
        int sum = 0;

        foreach (int num in numbersList) 
        {
                sum += num;
        }

            Console.WriteLine($"The sum is: {sum}");

            int numberOfNumbers = (numbersList.Count);

            int average = sum/numberOfNumbers;

            Console.WriteLine($"The average is {average}");

            int largestNumber = -1000000000;

            foreach (int num in numbersList) 
            {
                if (num > largestNumber) {
                    largestNumber = num;
                }
            }

            Console.WriteLine($"The largest number is {largestNumber}");
        
    }
}