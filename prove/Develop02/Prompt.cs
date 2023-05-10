using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Prompt
    {
        public List<string> prompts;
        
        public Prompt()
        {
            prompts = new List<string>();
            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
            prompts.Add("Favorite animal today and why.");
            prompts.Add("What am I grateful for today?");
            prompts.Add("What was the most surprising thing that happened today?");
            prompts.Add("What did I do today that I am proud of?");
            prompts.Add("What are some potential solutions to a problem I'm facing right now?");
            prompts.Add("What superpower would have come in handy today?");
        }

        private readonly Random _random = new Random();
        public void GetRandomPrompt()
        {
            int newNum = _random.Next(0,10);
            Console.WriteLine($"{prompts[newNum]}");
        }
    }
}