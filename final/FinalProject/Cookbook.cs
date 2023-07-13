using System;
using System.Collections.Generic;
using System.IO;

namespace Final
{
    public class Cookbook
    {
        private List<Recipe> _book = new List<Recipe>();

        public Cookbook()
        {}

        public void LoadBook(string fileName)
        {
            //get recipes from a save file
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("@");

                //retrieve recipe name
                string name = parts[0];
                Recipe thisRecipe = new Recipe(name);

                //retrieve cook steps
                string[] allSteps = parts[1].Split("*");
                foreach (string thisStep in allSteps)
                {
                    thisRecipe.StepFromSave(thisStep);
                }

                //retrieve ingredients
                string[] allIngredients = parts[2].Split("*");
                foreach (string thisString in allIngredients)
                {
                    thisRecipe.IngredientFromSave(thisString);
                }

                _book.Add(thisRecipe);
            }

            //show the user the recipes they have now
            Console.WriteLine("Your cookbook now includes the following: ");
            this.ViewBook();
        }

        public void SaveBook(string fileName)
        {
            //save cookbook under provided name
            using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Recipe thisRecipe in _book)
                    {
                        outputFile.WriteLine(thisRecipe.SaveWriteUp());
                    }
                }
        }

        public void NewRecipe(string name)
        {
            //create a brand spankin new recipe
            Recipe newRecipe = new Recipe(name);
            newRecipe.AddIngredients();
            newRecipe.AddSteps();
            _book.Add(newRecipe);
        }

        public void ViewBook()
        {
            //show the user what recipes they have in their cookbook
            Console.WriteLine("Here is a list of your recipes: ");
            int counter = 0;
            foreach (Recipe thisRecipe in _book)
            {
                counter += 1;
                string bobName = thisRecipe.GetName();
                Console.WriteLine($"{counter}. {bobName}");
            }
        }

        public void CookRecipe(int recipeIndex)
        {
            _book[recipeIndex].Cook();
        }
    }
}