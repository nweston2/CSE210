using System;
using System.Threading;

namespace Develop04
{
    public class Breathing:Activity
    {
        public Breathing()
        {
            _activityName = "breathing";
            _startingMessageSecondary = "relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing. ";
        }

        private void BreatheIn()
        {
            int timerCount = 4;
            Console.WriteLine();
            Console.Write("Breathe in ... ");
            while (timerCount > 0)
            {
                Console.Write($"{timerCount}\b");
                Thread.Sleep(1000);
                timerCount -= 1;
            }
            Console.WriteLine(" ");
        }

        private void BreatheOut()
        {
            int timerCount = 6;
            Console.Write("Breathe out ... ");
            while (timerCount > 0)
            {
                Console.Write($"{timerCount}\b");
                Thread.Sleep(1000);
                timerCount -= 1;
            }
            Console.WriteLine(" ");
        }

        public void RunBreathing()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_userTimer);
            DateTime currentTime = DateTime.Now;

            while (currentTime < endTime)
            {
                this.BreatheIn();
                this.BreatheOut();
                currentTime = DateTime.Now;
            }
        }
    }
}