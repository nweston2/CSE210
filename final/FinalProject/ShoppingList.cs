using System;
using System.Collections.Generic;

namespace Final
{
    public class ShoppingList
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public ShoppingList()
        {}

        public void AddToList(Recipe thisRecipe)
        {
            //put new ingredients into the shopping list from a recipe
            List<Ingredient> newIngredients = thisRecipe.GetIngredients();
            foreach (Ingredient thisIngredient in newIngredients)
            {
                _ingredients.Add(thisIngredient);
            }
        }

        public void AlreadyHave(int ingredientReference)
        {
            //removes item from list if user already has it
            ingredientReference -= 1;
            _ingredients.RemoveAt(ingredientReference);
        }

        public void ViewList()
        {
            //shows user current shopping list
            int counter = 0;
            foreach (Ingredient thisIngredient in _ingredients)
            {
                counter += 1;
                Console.Write($"{counter}. {thisIngredient.SaveWriteUp()}");
            }
        }

        public void SaveList(string fileName)
        {
            //sends shopping list to "printable" file
        }
    }
}