using System;
using System.Collections.Generic;

namespace Final
{
    public class Recipe
    {
        private List<CookStep> _process = new List<CookStep>();
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public void Cook()
        {}

        public void AddStep(CookStep newStep)
        {
            _process.Add(newStep);
        }

        public void AddIngredient(Ingredient newIngredient)
        {
            _ingredients.Add(newIngredient);
        }
    }
}