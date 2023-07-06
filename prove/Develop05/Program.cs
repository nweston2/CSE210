using System;
using System.Collections.Generic;
using System.IO;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int totalPoints = 0;
            string userChoice = "0";
            List<Goal> userGoals = new List<Goal>();

            while (userChoice != "6")
            {
                //Tally score
                totalPoints = 0;
                foreach (Goal goal in userGoals)
                {
                    int currentPoints = goal.Tally();
                    totalPoints += currentPoints;
                }

                //Points
                Console.WriteLine($"You have {totalPoints} points.");
                if (totalPoints >= 500)
                {
                    Console.WriteLine("Wow! You've got over 500 points! Impressive!");
                }

                else if (totalPoints >= 1000)
                {
                    Console.WriteLine("Incredible! You've surpassed 1000 points!");
                }

                else if(totalPoints >= 2000)
                {
                    Console.WriteLine("You're a goal finishing machine!! Keep up the great work!");
                }

                //Menu
                Console.WriteLine("\nMenu Options: ");
                Console.WriteLine("1. Create goal");
                Console.WriteLine("2. List goals");
                Console.WriteLine("3. Save goals");
                Console.WriteLine("4. Load goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                userChoice = Console.ReadLine();


                //Create a brand spankin' new goal
                if (userChoice == "1")
                {
                    Console.Clear();
                    Goal newGoal = new Goal();
                    Console.WriteLine("\nThe types of goals are:");
                    Console.WriteLine("1. Simple goal (nice and straightforward)");
                    Console.WriteLine("2. Eternal goal (an activity that needs to be repeated indefinitely)");
                    Console.WriteLine("3. Checklist goal (needs to be done a certain number of times)");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    if (goalType == "1")
                    {
                        newGoal = new Simple();
                    }

                    else if (goalType == "2")
                    {
                        newGoal = new Eternal();
                    }

                    else if (goalType == "3")
                    {
                        newGoal = new Checklist();
                    }

                    newGoal.CreateNew();
                    userGoals.Add(newGoal);
                    Console.WriteLine("");
                }

                //Display all current goals
                else if (userChoice == "2")
                {
                    Console.Clear();
                    int num = 0;
                    foreach (Goal goal in userGoals)
                    {
                        num += 1;
                        string displayString = goal.DisplayGoal();
                        Console.WriteLine($"{num}. {displayString}");
                    }
                    Console.WriteLine("");
                }

                //Save goals
                else if (userChoice == "3")
                {
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? (don't include .txt or other filetypes) ");
                    string fileName = Console.ReadLine();
                    fileName += ".txt";

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goal thisGoal in userGoals)
                        {
                            string fileInput = thisGoal.WriteToFile();
                            outputFile.WriteLine(fileInput);
                        }
                    }
                    Console.WriteLine("");
                }

                //Load Goals
                else if (userChoice == "4")
                {
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? (don't include .txt or other filetypes) ");
                    string fileName = Console.ReadLine();
                    fileName += ".txt";

                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("*");
                        Goal newGoal = new Goal();
                        if (parts[0] == "Simple")
                        {
                            newGoal = new Simple();
                        }

                        else if (parts[0] == "Eternal")
                        {
                            newGoal = new Eternal();
                        }

                        else if (parts[0] == "Checklist")
                        {
                            newGoal = new Checklist();
                        }

                        newGoal.CreateOld(parts[1]);
                        userGoals.Add(newGoal);
                    }
                    Console.WriteLine("Success!\n");
                }

                //Record an event
                else if (userChoice == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Your goals are: ");
                    int iteration = 0;
                    foreach (Goal thisGoal in userGoals)
                    {
                        iteration += 1;
                        Console.WriteLine($"{iteration}. {thisGoal.GetName()}");
                    }
                    Console.Write("Which goal did you accomplish? ");
                    string accomplishedString = Console.ReadLine();
                    int accomplishedInt = int.Parse(accomplishedString);
                    accomplishedInt -= 1;

                    if (userGoals[accomplishedInt].Accomplished())
                    {
                        Console.WriteLine("It seems you've already finished this goal.");
                    }

                    else
                    {
                        userGoals[accomplishedInt].CompleteGoal();
                        Console.WriteLine("Congradulations! You scored some points!\n");
                    }
                }

                //Thanks for coming
                else if (userChoice == "6")
                {
                    Console.WriteLine("Good luck out there!");
                }


                //For those smart alecs and the really confused
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please select a valid number.");
                }
            }
        }
    }
}