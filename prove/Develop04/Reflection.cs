using System;

namespace Develop04
{
    public class Reflection:Activity
    {
        private string _messageReflectionEnd = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        private void StartingMessage()
        {
            Console.Write($"{_startingMessageBasic} {_messageReflectionEnd}");
        }
    }
}