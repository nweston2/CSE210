using System;
using System.Collections.Generic;

namespace Develop02
    {
    class Program
        {
            static void Main(string[] args)
            {
                // Entry myEntry = new Entry();
                // myEntry.Hold("What is your name?", "Noah Weston", "8 May 2023");

                // Journal journal1 = new Journal();
                // journal1.AddEntry(myEntry);

                // List<Entry> entries = journal1.GetAllEntries();
                // foreach (Entry entry in entries)
                // {
                //     string message = entry.ConvertToString();
                //     Console.WriteLine(message);
                // }
                string userChoice = "";
                Journal journal1 = new Journal();

                while (userChoice != "5")
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. New entry");
                    Console.WriteLine("2. Display journal");
                    Console.WriteLine("3. Save journal");
                    Console.WriteLine("4. Load journal");
                    Console.WriteLine("5. Quit");

                    userChoice = Console.ReadLine();
                    Prompt prompts = new Prompt();
                    if (userChoice == "1")
                    {
                        Console.WriteLine();
                        string entryPrompt = prompts.GetRandomPrompt();
                        Console.WriteLine(entryPrompt);
                    }

                    else if (userChoice == "2")
                    {
                    }

                    else if (userChoice == "3")
                    {}

                    else if (userChoice == "4")
                    {}
                }
            }
        }
    }