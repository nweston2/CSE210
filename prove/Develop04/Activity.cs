using System;
using System.Threading;

namespace Develop04
{
    public class Activity
    {
        protected string _startingMessageBasic = "This activity will help you";

        public void Timer(int userTimer,string writeIn)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(userTimer);

            Thread.Sleep(3000);

            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                Console.WriteLine(writeIn);
            }
        }

        public Activity()
        {}
    }
}