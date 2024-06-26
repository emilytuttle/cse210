using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    
        List<string> _prompts = new List<string>
            { "How can I challenge myself to think outside of the box and embrace new and creative ideas?", "Write about a place that has had a significant impact on your life, and what memories or emotions it brings up for you.", "Write a story from the perspective of an animal who is trying to survive in the wilderness.", "How am I feeling today?" };

        
        public string GetRandomPrompt()
        {
            
            int highNum = (_prompts.Count) -1;       
            Random randomGenerator = new Random();
            int promptIndex = randomGenerator.Next(0, highNum);
            string randomPrompt = _prompts [promptIndex];
            return randomPrompt;
        }
        
    
}