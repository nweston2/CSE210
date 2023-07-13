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

            while (userChoice != 7)
            {
                //Menu
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Load cookbook");
                Console.WriteLine("2. Save current cookbook");
                Console.WriteLine("3. View current cookbook");
                Console.WriteLine("4. Add recipe");
                Console.WriteLine("5. Make shopping list");
                Console.WriteLine("6. Get cooking");
                Console.WriteLine("7. Quit\n");
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
                
                //Make shopping list
                else if (userChoice == 5)
                {
                    ShoppingList currentShoppingList = new ShoppingList();

                    //shopping list menu
                    string listChoice = "";
                    Console.Clear();
                    while (listChoice != "4")
                    {
                        Console.WriteLine("What would you like to do? ");
                        Console.WriteLine("1. View shopping list");
                        Console.WriteLine("2. Edit shopping list");
                        Console.WriteLine("3. Save shopping list");
                        Console.WriteLine("4. Back to main menu");
                        listChoice = Console.ReadLine();

                        //view list
                        if (listChoice == "1")
                        {
                            currentShoppingList.ViewList();
                        }

                        //edit list
                        else if (listChoice == "2")
                        {
                            //add or remove?
                            Console.Clear();
                            string editChoice;
                            Console.Write("Would you like to 'add' items to the list or 'remove' them? ");
                            editChoice = Console.ReadLine();

                            //add new things to shopping list
                            if (editChoice == "add")
                            {
                                //which recipe needs ingredients
                                string addChoiceString;
                                Console.WriteLine("Enter the index of the recipe you would like to get ingredients for. ");
                                currentBook.ViewBook();
                                addChoiceString = Console.ReadLine();
                                int addChoice = int.Parse(addChoiceString);
                                addChoice -= 1;

                                currentShoppingList.AddToList(currentBook.GetRecipe(addChoice));
                            }

                            //remove items from shopping list
                            else if (editChoice == "remove")
                            {
                                string youDone = "";
                                while (youDone != "n")
                                {
                                    string removeString;
                                    Console.WriteLine("Which item would you like to remove? ");
                                    currentShoppingList.ViewList();
                                    removeString = Console.ReadLine();
                                    int removeInt = int.Parse(removeString);
                                    removeInt -= 1;
                                    currentShoppingList.AlreadyHave(removeInt);

                                    Console.Write("Would you like to remove another item? (y/n) ");
                                    youDone = Console.ReadLine();
                                }
                            }
                        }

                        //save list
                        else if (listChoice == "3")
                        {
                            string saveName;
                            Console.WriteLine("What would you like to name your shopping list? ");
                            saveName = Console.ReadLine();
                            saveName += ".txt";

                            currentShoppingList.SaveList(saveName);
                        }

                        //exit
                        else if (listChoice == "4")
                        {
                            //make sure they understand the consequences of their actions
                            string exitCheck = "";
                            Console.Write("Are you sure you want to leave? All unsaved data will be lost. (y/n) ");
                            exitCheck = Console.ReadLine();

                            //reenter list society
                            if (exitCheck == "n")
                            {
                                listChoice = "0";
                            }
                        }
                    }
                }
                
                //Get cooking
                else if (userChoice == 6)
                {
                    Console.WriteLine("Please enter the index for the recipe you would like to cook: ");
                    currentBook.ViewBook();
                    string recipeIndexString = Console.ReadLine();
                    int recipeIndex = int.Parse(recipeIndexString);
                    recipeIndex -= 1;
                    currentBook.CookRecipe(recipeIndex);
                }
                
                //Quit
                else if (userChoice == 7)
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