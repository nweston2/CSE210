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
            Cookbook currentBook = new Cookbook();
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
                Console.WriteLine("10. Quit");
                userChoiceString = Console.ReadLine();
                userChoice = int.Parse(userChoiceString);
                
                //Load cookbook
                if (userChoice == 1)
                {}

                //Save current cookbook
                else if (userChoice == 2)
                {}

                //View current cookbook
                else if (userChoice == 3)
                {
                    currentBook.ViewBook();
                }
                
                //Add recipe
                else if (userChoice == 4)
                {
                    Console.Write("What would you like to call your new recipe? ");
                    string recipeName = Console.ReadLine();
                    currentBook.NewRecipe(recipeName);
                }
                
                //View shopping list
                else if (userChoice == 5)
                {}
                
                //Load shopping list
                else if (userChoice == 6)
                {}
                
                //Save shopping list
                else if (userChoice == 7)
                {}
                
                //Edit shopping list
                else if (userChoice == 8)
                {}
                
                //Get cooking
                else if (userChoice == 9)
                {}
                
                //Quit
                else if (userChoice == 10)
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for cooking with us!");
                }
                
                //For the smart alecs
                else
                {
                    Console.WriteLine("Please select a valid number");
                }
            }
        }
    }
}