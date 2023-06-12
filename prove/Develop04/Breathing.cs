using System;

namespace Develop04
{
    public class Breathing:Activity
    {
        public Breathing():base()
        {}
        private string _messageBreathingEnd = "relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing. ";
        
        public void StartingMessage()
        {
            Console.WriteLine($"{_startingMessageBasic} {_messageBreathingEnd}");
        }
        
    }
}