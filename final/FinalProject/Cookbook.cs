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
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }
            Console.WriteLine("Your cookbook now includes the following: ");
            this.ViewBook();
        }

        public void SaveBook(string fileName)
        {
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
            Recipe newRecipe = new Recipe(name);
            newRecipe.AddIngredients();
            newRecipe.AddSteps();
            _book.Add(newRecipe);
        }

        public void ViewBook()
        {
            int counter = 0;
            foreach (Recipe thisRecipe in _book)
            {
                counter += 1;
                string bobName = thisRecipe.GetName();
                Console.WriteLine($"{counter}. {bobName}");
            }
        }
    }
}