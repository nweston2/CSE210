using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
    {
    class Program
        {
            static void Main(string[] args)
            {
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
                        string response = Console.ReadLine();
                        Console.WriteLine();

                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        Entry entry1 = new Entry();
                        entry1.Hold(entryPrompt, response, dateText);
                        journal1.AddEntry(entry1);
                    }

                    else if (userChoice == "2")
                    {
                        Console.WriteLine();
                        List<Entry> journalEntries = journal1.GetAllEntries();
                        foreach (Entry entry in journalEntries)
                        {
                            string printable = entry.ConvertToString();
                            Console.WriteLine(printable);
                            Console.WriteLine();
                        }
                    }

                    else if (userChoice == "3")
                    {
                        string fileName = "myFile.txt";
                        List<Entry> journalEntries = journal1.GetAllEntries();

                        using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
                            foreach (Entry entry in journalEntries)
                            {
                                string printable = entry.WriteToFile();
                                outputFile.WriteLine(printable);
                            }
                        }

                        Console.WriteLine();
                    }

                    else if (userChoice == "4")
                    {
                        string filename = "myFile.txt";
                        string[] lines = System.IO.File.ReadAllLines(filename);

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split("*");

                            string fileDate = parts[0];
                            string filePrompt = parts[1];
                            string fileResponse = parts[2];

                            Entry fileEntry = new Entry();
                            fileEntry.Hold(filePrompt, fileResponse, fileDate);
                            journal1.AddEntry(fileEntry);
                        }
                    }
                }
            }
        }
    }