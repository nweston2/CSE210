using System;
using System.Collections.Generic;

namespace Develop04
{
    public class Reflection:Activity
    {
        private List<string> prompts = new List<string>(); 
        private List<string> thoughts = new List<string>();
        public Reflection()
        {
            _activityName = "reflection";
            _startingMessageSecondary = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            prompts.Add("Think of a time when you stood up for someone else.");
            prompts.Add("Think of a time when you did something really difficult.");
            prompts.Add("Think of a time when you helped someone in need.");
            prompts.Add("Think of a time when you did something truly selfless.");

            thoughts.Add("Why was this experience meaningful to you?");
            thoughts.Add("Have you ever done anything like this before?");
            thoughts.Add("How did you get started?");
            thoughts.Add("How did you feel when it was complete?");
            thoughts.Add("What made this time different than other times when you were not as successful?");
            thoughts.Add("What is your favorite thing about this experience?");
            thoughts.Add("What could you learn from this experience that applies to other situations?");
            thoughts.Add("What did you learn about yourself through this experience?");
            thoughts.Add("How can you keep this experience in mind in the future?");
        }

        //Decide what the user will reflect on
        private Random _random = new Random();
        private string _choice;
        public void SelectPrompt()
        {
            int promptNum = _random.Next(0,3);
            _choice = prompts[promptNum];
        }

        private int _thoughtCount;
        private string _thoughtChoice;
        public string SelectThought()
        {
            _thoughtCount = thoughts.Count;
            int thoughtNum = _random.Next(0,(_thoughtCount-1));
            _thoughtChoice = thoughts[thoughtNum];
            thoughts.Remove(_thoughtChoice);
            if (_thoughtCount == 1)
            {
                thoughts.Add("Cheers. You've found the limit of this program.");
            }
            return _thoughtChoice;
        }

        public void RunReflection()
        {
            Console.WriteLine("\nConsider the following prompt:");
            this.SelectPrompt();
            Console.WriteLine($"\t-----{_choice}-----");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder each of the following questions as they relate to this experience. No input is required.");
            this.Loading();
            this.Loading();
            Console.Clear();
            Console.Write("  ");
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_userTimer);
            DateTime currentTime = DateTime.Now;

            while (currentTime < endTime)
            {
                Console.WriteLine($"> {SelectThought()}");
                this.Loading();
                this.Loading();
                currentTime = DateTime.Now;
            }
        }
    }
}