using System;

namespace Develop04
{
    public class Listing:Activity
    {
        private string _messageListingEnd = "reflect on the good things in your life by having you list as many things as you can in a certain area.";

        public void StartingMessage()
        {
            Console.WriteLine($"{_startingMessageBasic} {_messageListingEnd}");
        }
    }
}