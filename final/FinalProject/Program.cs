using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup and greeting
            string userChoiceString = "0";
            int userChoice = 0;
            Console.WriteLine("Welcome to the Comfy Cookbook!\n");

            while (userChoice != 10)
            {
                //Menu
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Load cookbook");
                Console.WriteLine("2. Save current cookbook");
                Console.WriteLine("3. View current cookbook");
                Console.WriteLine("4. Add recipe");
                Console.WriteLine("5. View shopping list");
                Console.WriteLine("6. Load shopping list");
                Console.WriteLine("7. Save shopping list");
                Console.WriteLine("8. Edit shopping list");
                Console.WriteLine("9. Get cooking");
                userChoiceString = Console.ReadLine();
                userChoice = int.Parse(userChoiceString);
                //Load cookbook
                if (userChoice == 1)
                {}

                //Save current cookbook
                else if (userChoice == 2)
                {}

                //View current cookbook
                else if (userChoice == 2)
                {}
                
                //Add recipe
                else if (userChoice == 2)
                {}
                
                //View shopping list
                else if (userChoice == 2)
                {}
                
                //Load shopping list
                else if (userChoice == 2)
                {}
                
                //Save shopping list
                else if (userChoice == 2)
                {}
                
                //Edit shopping list
                else if (userChoice == 2)
                {}
                
                //Get cooking
                else if (userChoice == 2)
                {}
                
                //Quit
                else if (userChoice == 2)
                {}
                
                //For the smart alecs
                else
                {
                    Console.WriteLine("Please select a valid number");
                }
            }
        }
    }
}