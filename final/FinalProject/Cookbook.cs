using System;
using System.Collections.Generic;

namespace Final
{
    public class Cookbook
    {
        private List<Recipe> _book = new List<Recipe>();

        public Cookbook()
        {}

        public List<Recipe> LoadBook(string fileName)
        {
            return _book;
        }

        public void SaveBook(string fileName)
        {}

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