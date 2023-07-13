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
            Console.Clear();
            Console.WriteLine("Welcome to the Comfy Cookbook!");

            while (userChoice != 10)
            {
                //Menu
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Load cookbook");
                Console.WriteLine("2. Save current cookbook");
                Console.WriteLine("3. View current cookbook");
                Console.WriteLine("4. Add recipe");
                Console.WriteLine("5. View shopping list");
                Console.WriteLine("6. Save shopping list");
                Console.WriteLine("7. Edit shopping list");
                Console.WriteLine("8. Get cooking");
                Console.WriteLine("9. Quit\n");
                userChoiceString = Console.ReadLine();
                userChoice = int.Parse(userChoiceString);
                
                //Load cookbook
                if (userChoice == 1)
                {
                    Console.Write("What is the name of the cookbook you would like to load? ");
                    string cookBookName = Console.ReadLine();
                    cookBookName += ".txt";
                    currentBook.LoadBook(cookBookName);
                }

                //Save current cookbook
                else if (userChoice == 2)
                {
                    Console.Write("What would you like to name this cookbook? ");
                    string cookBookName = Console.ReadLine();
                    cookBookName += ".txt";
                    currentBook.SaveBook(cookBookName);
                }

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
                
                //Save shopping list
                else if (userChoice == 6)
                {}
                
                //Edit shopping list
                else if (userChoice == 7)
                {}
                
                //Get cooking
                else if (userChoice == 8)
                {
                    Console.WriteLine("Please enter the index for the recipe you would like to cook: ");
                    currentBook.ViewBook();
                    string recipeIndexString = Console.ReadLine();
                    int recipeIndex = int.Parse(recipeIndexString);
                    recipeIndex -= 1;
                    currentBook.CookRecipe(recipeIndex);
                }
                
                //Quit
                else if (userChoice == 9)
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