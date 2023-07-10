using System;
using System.Collections.Generic;

namespace Final
{
    public class Recipe
    {
        private string _name;
        private List<CookStep> _process = new List<CookStep>();
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Recipe(string name)
        {
            _name = name;
        }

        public void Cook()
        {}

        public void AddSteps()
        {
            string instruction = "";
            while (instruction != "quit")
            {
                CookStep newStep = new CookStep();
                Console.Write("Enter a step of the cooking process (Enter \"quit\" to finish): ");
                instruction = Console.ReadLine();
                if (instruction != "quit")
                {
                    newStep.AddInstruction(instruction);
                    _process.Add(newStep);
                }
            }
            Console.WriteLine("");
        }

        public void AddIngredients()
        {
            string ingredientName = "";
            while (ingredientName != "quit")
            {
                Console.Write("Enter an ingredient needed (Enter \"quit\" when finished): ");
                ingredientName = Console.ReadLine();
                if (ingredientName != "quit")
                {
                    Console.Write("What unit of measurement will this ingredient use? (Enter \"solid\" for individual items) ");
                    string unit = Console.ReadLine();
                    Console.Write("How much will you need? (Units are provided in previous step. Enter fractions as a decimal if necessary) ");
                    string amountString = Console.ReadLine();
                    float amount = float.Parse(amountString);
                    Ingredient newIngredient = new Ingredient();
                    newIngredient.SetStuff(ingredientName, unit, amount);
                    _ingredients.Add(newIngredient);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public string GetName()
        {
            return _name;
        }
    }
}