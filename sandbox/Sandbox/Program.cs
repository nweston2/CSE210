using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Command> commands = new Dictionary<string, Command>();
            commands["breathe"] = new StartBreathing();
            commands["list"] = new StartListing();
            bool wtf = true;

            while (wtf == true)
            {
                Console.WriteLine("What do you want to do");
                string response = Console.ReadLine();
                Command command = commands[response];
                command.Execute();
            }
        }
    }
}