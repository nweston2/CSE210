using System;
using System.Threading;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            string _userChoice = "0";
            int breaths = 0;
            int reflections = 0;
            int lists = 0;

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
                    bob.RunBreathing();
                    bob.EndingMessage();
                    breaths += 1;
                }

                else if (_userChoice == "2")
                {
                    Reflection bob = new Reflection();
                    bob.StartingMessage();
                    bob.RunReflection();
                    bob.EndingMessage();
                    reflections += 1;
                }

                else if (_userChoice == "3")
                {
                    Listing bob = new Listing();
                    bob.StartingMessage();
                    bob.RunListing();
                    bob.EndingMessage();
                    lists += 1;
                }

                else if (_userChoice == "4")
                {
                    Console.WriteLine("Thanks for coming here to relax! While you were here, you completed:");
                    Console.WriteLine($"{breaths} breathing activities");
                    Console.WriteLine($"{reflections} reflection activities");
                    Console.WriteLine($"{lists} listing activities");
                    Console.WriteLine("Come again soon");
                    Console.Write("O>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b>");
                }
            }
        }
    }
}