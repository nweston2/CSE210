using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            string _userChoice = "0";

            while (_userChoice != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a choice from the menu: ");
                _userChoice = Console.ReadLine();
                Console.Clear();

                if (_userChoice == "1")
                {
                    Breathing bob = new Breathing();
                    bob.StartingMessage();
                    bob.Run();
                    bob.EndingMessage();
                }

                else if (_userChoice == "2")
                {
                    Activity bob = new Reflection();
                    bob.StartingMessage();
                    bob.EndingMessage();
                }

                else if (_userChoice == "3")
                {
                    Activity bob = new Listing();
                    bob.StartingMessage();
                    bob.EndingMessage();
                }

                else if (_userChoice == "4")
                {}
            }
        }
    }
}