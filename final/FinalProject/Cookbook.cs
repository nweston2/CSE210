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

        public void NewRecipe()
        {}

        public List<Recipe> GetRecipes()
        {
            return _book;
        }
    }
}