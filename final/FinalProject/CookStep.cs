using System;
using System.Collections.Generic;

namespace Final
{
    public class CookStep
    {
        private string _instruction;
        private List<Ingredient> _need = new List<Ingredient>();

        public void AddInstruction(string newInstruction)
        {
            _instruction = newInstruction;
        }

        public void AddIngredient(Ingredient newIngredient)
        {
            _need.Add(newIngredient);
        }
    }
}