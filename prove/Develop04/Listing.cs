using System;
using System.Collections.Generic;

namespace Develop04
{
    public class Listing:Activity
    {
        private List<string> prompts = new List<string>();
        public Listing()
        {
            _activityName = "listing";
            _startingMessageSecondary = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
            prompts.Add("Who are people that you appreciate?");
            prompts.Add("What are personal strengths of yours?");
            prompts.Add("Who are people that you have helped this week?");
            prompts.Add("When have you felt the Holy Ghost this month?");
            prompts.Add("Who are some of your personal heroes?");
        }

        private Random _random = new Random();
        private string _choice;
        public void SelectPrompt()
        {
            int promptNum = _random.Next(0,3);
            _choice = prompts[promptNum];
        }

        public void RunListing()
        {
            Console.WriteLine("List as many responses as you can to the following prompt:");
            this.SelectPrompt();
            Console.WriteLine($"-----{_choice}-----");
            this.Loading();
            Console.Write("\b");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_userTimer);
            DateTime currentTime = DateTime.Now;

            List<string> _responses = new List<string>();
            string response;

            while (currentTime < endTime)
            {
                Console.Write("> ");
                response = Console.ReadLine();
                _responses.Add(response);
                currentTime = DateTime.Now;
            }

            Console.WriteLine($"You recorded {_responses.Count} items!");
            this.Loading();
        }
    }
}