using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

public class Journal
{
    
       List<string> _entries = new List<string>();

        public void AddEntry(string entry)
        {
            _entries.Add(entry);
           
        }

        public void DisplayAll()
        {
            string filename = "journal.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"Entry: {entry}");
                Console.WriteLine("");
            }
        }

        public void SaveToFile(string date, string prompt, string entry)
        {
            using (StreamWriter outputFile = new StreamWriter("journal.txt", true))
            {
                outputFile.WriteLine($"{date}|{prompt}|{entry}");
            }
        }

    
}