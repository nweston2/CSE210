using System;
using System.Collections.Generic;

namespace Develop02
    {
    class Program
        {
            static void Main(string[] args)
            {
                Entry myEntry = new Entry();
                myEntry.Hold("What is your name?", "Noah Weston", "8 May 2023");

                Journal journal = new Journal();
                journal.AddEntry(myEntry);

                List<Entry> entries = journal.GetAllEntries();
                foreach (Entry entry in entries)
                {
                    string message = entry.ConvertToString();
                    Console.WriteLine(message);
                }
            }
        }
    }