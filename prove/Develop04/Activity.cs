using System;
using System.Threading;

namespace Develop04
{
    public class Activity
    {
        public Activity()
        {}

        private string _startingMessageBasic = "This activity will help you";
        protected string _startingMessageSecondary = "relax or something I guess";
        protected string _activityName;
        public int _userTimer;

        //Initiate the activity
        public void StartingMessage()
        {
            Console.WriteLine($"\nWelcome to the {_activityName} activity!\n");
            Console.WriteLine($"{_startingMessageBasic} {_startingMessageSecondary}\n");
            Console.Write("How long would you like your session to last (in seconds)? ");
            string _userTimerString = Console.ReadLine();
            _userTimer = int.Parse(_userTimerString);
            Console.Clear();
            Console.WriteLine("Get ready...");
            this.Loading();
        }

        //Wrap up the activity
        public void EndingMessage()
        {
            Console.WriteLine("\nWell done!!");
            this.Loading();
            Console.WriteLine($"\nYou have completed another {_userTimer} seconds of the {_activityName} activity!");
            this.Loading();
            Console.Clear();
        }

        public void Timer(string writeIn)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_userTimer);

            Thread.Sleep(3000);

            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                Console.WriteLine(writeIn);
            }
        }

        //Display fun little widget-majig while waiting
        public void Loading()
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b(");
            Thread.Sleep(500);
            Console.Write("\b{");
            Thread.Sleep(500);
            Console.Write("\b(");
            Thread.Sleep(500);
            Console.Write("\b|");
            Thread.Sleep(500);
            Console.Write("\b)");
            Thread.Sleep(500);
            Console.Write("\b}");
            Thread.Sleep(500);
            Console.Write("\b)");
            Thread.Sleep(500);
            Console.Write("\b ");
            Thread.Sleep(500);
        }
    }
}